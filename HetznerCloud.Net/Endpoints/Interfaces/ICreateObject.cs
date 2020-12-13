using System.Threading.Tasks;
using HetznerCloud.Net.Objects;

namespace HetznerCloud.Net.Endpoints.Interfaces
{
    
    public interface ICreateObject<TC, TI, T>
        where TC : CreateObjectBase, new()
        where TI : SingleObjectResultBase<T>, new()
    {
        public Task<T> CreateAsync(TC objectToCreate);
    }
}