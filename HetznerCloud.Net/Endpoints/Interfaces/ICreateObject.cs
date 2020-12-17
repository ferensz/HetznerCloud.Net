using System.Threading.Tasks;
using HetznerCloud.Net.Objects;

namespace HetznerCloud.Net.Endpoints.Interfaces
{
    public interface ICreateObject<in TC, T>
        where TC : CreateObjectBase, new()
    {
        public Task<T> CreateAsync(TC objectToCreate);
    }
}