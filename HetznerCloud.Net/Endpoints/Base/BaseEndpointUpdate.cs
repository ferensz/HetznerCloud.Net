using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Objects;

namespace HetznerCloud.Net.Endpoints.Base
{
    public class BaseEndpointUpdate<T, TE, TI, TU>: BaseEndpoint<T, TE, TI>
        where T : SingleObjectResultBase<TI>, new() 
        where TE : MultipleObjectsResultBase<TI>, new()
        where TU : UpdateObjectBase, new()
    {
        private readonly string _endPointPath;
        
        public BaseEndpointUpdate(string apiToken, string endPointPath) : base(apiToken, endPointPath)
        {
            _endPointPath = endPointPath;
        }
        
        public async Task<TI> UpdateAsync(long id, TU objectToUpdate)
        {
            var res = await SendPutRequest($"{_endPointPath}/{id}", objectToUpdate);
            var createdObject =
                JsonSerializer.Deserialize<T>(res, Settings.JsonSerializerOptions);

            return createdObject.Data;
        }
    }
}