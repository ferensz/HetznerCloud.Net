using System.Threading.Tasks;

namespace HetznerCloud.Net.Endpoints.Interfaces
{
    public interface IGetObject<T>
    {
        public Task<T> GetAsync(long id);
    }
}