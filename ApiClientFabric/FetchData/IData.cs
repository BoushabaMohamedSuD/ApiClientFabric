using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Remoting;
using Microsoft.ServiceFabric.Services.Remoting.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using System.Threading.Tasks;

namespace FetchData
{
    public interface IData:IService
    {
        Task<string> HelloWorldAsync();
    }
}
