using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Objects;

namespace HetznerCloud.Net.Endpoints.Base
{
    public class BaseEndpointCreate<T, TE, TI, TC> : BaseEndpoint<T, TE, TI>
        where T : SingleObjectResultBase<TI>, new() 
        where TE : MultipleObjectsResultBase<TI>, new()
        where TC : CreateObjectBase, new()
    {
        private readonly string _endPointPath;
        
        public BaseEndpointCreate(string apiToken, string endPointPath) : base(apiToken, endPointPath)
        {
            _endPointPath = endPointPath;
        }
        
        public async Task<TI> CreateAsync(TC objectToCreate)
        {
            objectToCreate.ValidateObject();
            
            var res = await SendPostRequest(_endPointPath, objectToCreate);
            var createdObject =
                JsonSerializer.Deserialize<T>(res, Settings.JsonSerializerOptions);

            return createdObject.Data;
        }
    }
}