using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Objects;

namespace HetznerCloud.Net.Endpoints.Base
{
    public class BaseEndpointUpdate<TS, TU, T>: BaseEndpoint
        where TS : SingleObjectResultBase<T>, new() 
        where TU : UpdateObjectBase, new()
    {
        private readonly string _endPointPath;
        
        public BaseEndpointUpdate(string apiToken, string endPointPath) : base(apiToken, endPointPath)
        {
            _endPointPath = endPointPath;
        }
        
        public async Task<T> UpdateAsync(long id, TU objectToUpdate)
        {
            var res = await SendPutRequest($"{_endPointPath}/{id}", objectToUpdate);
            var createdObject =
                JsonSerializer.Deserialize<TS>(res, Settings.JsonSerializerOptions);

            return createdObject.Data;
        }
    }
}