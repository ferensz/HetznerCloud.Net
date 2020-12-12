using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Core.Requests;
using HetznerCloud.Net.Exceptions;
using HetznerCloud.Net.Objects;

namespace HetznerCloud.Net.Endpoints
{
    public class BaseEndpoint<T, TE, TI> 
        where T : SingleObjectResultBase<TI>, new() 
        where TE : MultipleObjectsResultBase<TI>, new()
    {
        private readonly string _apiToken;

        private readonly string _endPointPath;

        /// <summary>
        /// User Agent string sent by the wrapper
        /// </summary>
        private readonly string _userAgentString = "Hetzner Cloud API .NET wrapper";

        /// <summary>
        /// Base URL of the API endpoint
        /// </summary>
        private readonly string _apiEndpoint = "https://api.hetzner.cloud/v1";

        /// <summary>
        /// Constructor of the BaseEndpoint
        /// </summary>
        /// <param name="apiToken">API token to access the Hetzner Cloud API</param>
        /// <param name="endPointPath">Path part of the URL for the endpoint</param>
        protected BaseEndpoint(string apiToken, string endPointPath)
        {
            _apiToken = apiToken;
            _endPointPath = endPointPath;
        }

        /// <summary>
        /// Generic method to get a single item from API with the given Id with type specified by the type parameter
        /// </summary>
        /// <param name="id">Id of the item</param>
        /// <returns>Single item with type specified by the type parameter</returns>
        public async Task<TI> GetAsync(long id)
        {
            var res = await SendRequest($"{_endPointPath}/{id}");
            var objectResult = JsonSerializer.Deserialize<T>(res, Settings.JsonSerializerOptions);

            // ReSharper disable once PossibleNullReferenceException
            // If the objectResult is null then an exception has been already thrown
            return objectResult.Data;
        }
        
        /// <summary>
        /// Generic method to get all items from API with type specified by the type parameter
        /// </summary>
        /// <returns>List of items with type specified by the type parameter</returns>
        public async Task<List<TI>> GetAllAsync()
        {
            List<TI> resultActions = new List<TI>();
             
            var res = await SendRequest(_endPointPath);
            var objectsResultPage = JsonSerializer.Deserialize<TE>(res, Settings.JsonSerializerOptions);
        
            if (objectsResultPage != null)
            {
                var lastPage = objectsResultPage.Meta.Pagination.LastPage;
                
                resultActions.AddRange(objectsResultPage.Data);
        
                while (objectsResultPage.Meta.Pagination.Page < lastPage)
                {
                    res = await SendRequest(_endPointPath);
                    objectsResultPage = JsonSerializer.Deserialize<TE>(res, Settings.JsonSerializerOptions);
            
                    // ReSharper disable once PossibleNullReferenceException
                    // If the objectResult is null then an exception has been already thrown
                    resultActions.AddRange(objectsResultPage.Data);
                }
            }
        
            return resultActions;
        }

        /// <summary>
        /// Generic method to delete an item through the API with the given Id
        /// </summary>
        /// <param name="id">Id of the item to be deleted</param>
        public async void DeleteAsync(long id)
        {
            await SendDeleteRequest($"{_endPointPath}/{id}", null);
        }

        /// <summary>
        /// Sends a get request to the API endpoint
        /// </summary>
        /// <param name="action">URL request path part</param>
        /// <returns>JSON string returned from the server</returns>
        internal async Task<string> SendRequest(string action)
        {
            CheckApiToken();

            var httpResponse = await GetHttpClient().GetAsync($"{_apiEndpoint}{action}");

            return await HandleResponse(httpResponse);
        }

        /// <summary>
        /// Sends a POST request to the API endpoint
        /// </summary>
        /// <param name="action">URL request path part</param>
        /// <param name="objectToSend">Object which will be serialized as JSON and sent to the API</param>
        /// <returns>JSOn string returned from the server</returns>
        internal async Task<string> SendPostRequest(string action, object objectToSend)
        {
            CheckApiToken();

            var httpResponse = await GetHttpClient()
                .SendAsync(GetHttpRequestMessage(HttpMethod.Post, action,
                    objectToSend == null
                        ? null
                        : new StringContent(JsonSerializer.Serialize(objectToSend), Encoding.UTF8,
                            "application/json")));

            return await HandleResponse(httpResponse);
        }

        /// <summary>
        /// Sends a DELETE request to the API endpoint
        /// </summary>
        /// <param name="action">URL request path part</param>
        /// <param name="objectToSend">Object which will be serialized as JSON and sent to the API</param>
        /// <returns>JSOn string returned from the server</returns>
        internal async Task<string> SendDeleteRequest(string action, object objectToSend)
        {
            CheckApiToken();

            var httpResponse = await GetHttpClient()
                .SendAsync(GetHttpRequestMessage(HttpMethod.Delete, action,
                    objectToSend == null
                        ? null
                        : new StringContent(JsonSerializer.Serialize(objectToSend), Encoding.UTF8,
                            "application/json")));

            return await HandleResponse(httpResponse);
        }

        /// <summary>
        /// Sends a POST request to the API endpoint
        /// </summary>
        /// <param name="action">URL request path part</param>
        /// <param name="objectToSend">Object which will be serialized as JSON and sent to the API</param>
        /// <returns>JSOn string returned from the server</returns>
        internal async Task<string> SendPutRequest(string action, object objectToSend)
        {
            CheckApiToken();

            var httpResponse = await GetHttpClient()
                .SendAsync(GetHttpRequestMessage(HttpMethod.Put, action,
                    objectToSend == null
                        ? null
                        : new StringContent(JsonSerializer.Serialize(objectToSend), Encoding.UTF8,
                            "application/json")));

            return await HandleResponse(httpResponse);
        }

        /// <summary>
        /// Returns a new preconfigured HttpClient to call the API
        /// </summary>
        /// <returns></returns>
        private HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", _userAgentString);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiToken);

            return client;
        }

        /// <summary>
        /// Returns a new HttpRequestMessage which can be used by the HttpClient
        /// </summary>
        /// <param name="method">Http method</param>
        /// <param name="action">URL request path part</param>
        /// <param name="content">HttpContent which will be used by the request</param>
        /// <returns>A complete HttpRequestMessage which can be used to interact with the API</returns>
        private HttpRequestMessage GetHttpRequestMessage(HttpMethod method, string action, HttpContent content)
        {
            HttpRequestMessage request;
            request = content != null
                ? new HttpRequestMessage(method, $"{_apiEndpoint}{action}") {Content = content}
                : new HttpRequestMessage(method, $"{_apiEndpoint}{action}");

            return request;
        }

        /// <summary>
        /// Checks the HttpResponse message and handles it based on the success property
        /// </summary>
        /// <param name="responseMessage">HttpResponseMessage which will be handled</param>
        /// <returns>JSON string returned by the API</returns>
        /// <exception>One of the exceptions sent by the API</exception>
        private async Task<string> HandleResponse(HttpResponseMessage responseMessage)
        {
            if (responseMessage.IsSuccessStatusCode)
            {
                var resultString = await responseMessage.Content.ReadAsStringAsync();
                CheckResponseContent(resultString);

                return resultString;
            }

            throw await HandleRequestError(responseMessage);
        }

        /// <summary>
        /// Chooses the appropriate exception based on the error result object
        /// </summary>
        /// <param name="responseMessage">HttpResponseMessage returned by the API</param>
        /// <returns>Appropriate exception based on the error result</returns>
        /// <exception></exception>
        private async Task<Exception> HandleRequestError(HttpResponseMessage responseMessage)
        {
            var errorResponse = await responseMessage.Content.ReadAsStringAsync();
            var errorObj =
                JsonSerializer.Deserialize<RequestErrorResult>(errorResponse, Settings.JsonSerializerOptions);

            if (errorObj != null)
            {
                switch (errorObj.Error.Code)
                {
                    case "not_found":
                        return new NotFoundException(errorObj.Error.Message);
                    default:
                        return new Exception($"Code: {errorObj.Error.Code} - Message: {errorObj.Error.Message}");
                }
            }

            throw new Exception("Could not determine the reason of the error");
        }

        /// <summary>
        /// Checks if the API token is filled out properly
        /// </summary>
        /// <exception cref="InvalidTokenException"></exception>
        private void CheckApiToken()
        {
            if (string.IsNullOrEmpty(_apiToken) || string.IsNullOrWhiteSpace(_apiToken))
                throw new InvalidTokenException("API access token cannot be null or empty");
        }

        // ReSharper disable once ParameterOnlyUsedForPreconditionCheck.Local
        /// <summary>
        /// Checks if the result string contains any data
        /// </summary>
        /// <param name="response">String needs to be checked</param>
        /// <exception cref="InvalidResponseException"></exception>
        private void CheckResponseContent(string response)
        {
            if (string.IsNullOrEmpty(response) || string.IsNullOrWhiteSpace(response))
                throw new InvalidResponseException(
                    "Response from the API is empty however the return code indicated success");
        }
    }
}