using System.Collections.Generic;
using System.Threading.Tasks;

namespace HetznerCloud.Net.Endpoints.Interfaces
{
    public interface IGetAllObjects<T>
    {
        public Task<List<T>> GetAllAsync();
    }
}