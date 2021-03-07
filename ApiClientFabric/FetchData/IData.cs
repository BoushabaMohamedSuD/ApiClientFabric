using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Remoting;
using Microsoft.ServiceFabric.Services.Remoting.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using System.Fabric;
using System.Fabric.Query;
using System.Threading.Tasks;

namespace FetchData
{
    public interface IData:IService
    {
        Task<string> HelloWorldAsync();
        Task<ApplicationList> getData(FabricClient fc);
    }
}
