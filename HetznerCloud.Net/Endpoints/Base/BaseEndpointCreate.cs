using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Objects;

namespace HetznerCloud.Net.Endpoints.Base
{
    public class BaseEndpointCreate<TS, TC, T> : BaseEndpoint
        where TS : SingleObjectResultBase<T>, new() 
        where TC : CreateObjectBase, new()
    {
        private readonly string _endPointPath;
        
        public BaseEndpointCreate(string apiToken, string endPointPath) : base(apiToken, endPointPath)
        {
            _endPointPath = endPointPath;
        }
        
        public async Task<T> CreateAsync(TC objectToCreate)
        {
            objectToCreate.ValidateObject();
            
            var res = await SendPostRequest(_endPointPath, objectToCreate);
            var createdObject =
                JsonSerializer.Deserialize<TS>(res, Settings.JsonSerializerOptions);

            return createdObject.Data;
        }
    }
}