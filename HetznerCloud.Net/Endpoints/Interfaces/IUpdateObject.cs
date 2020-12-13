using System.Threading.Tasks;
using HetznerCloud.Net.Objects;

namespace HetznerCloud.Net.Endpoints.Interfaces
{
    public interface IUpdateObject<TU, TI, T> 
        where TU : UpdateObjectBase, new()
        where TI : SingleObjectResultBase<T>, new()
    {
        public Task<T> UpdateAsync(long id, TU objectToUpdate);
    }
}