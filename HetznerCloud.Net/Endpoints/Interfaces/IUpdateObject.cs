using System.Threading.Tasks;
using HetznerCloud.Net.Objects;

namespace HetznerCloud.Net.Endpoints.Interfaces
{
    public interface IUpdateObject<in TU, T> 
        where TU : UpdateObjectBase, new()
    {
        public Task<T> UpdateAsync(long id, TU objectToUpdate);
    }
}