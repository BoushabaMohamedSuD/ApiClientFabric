using FetchData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using System;
using System.Collections.Generic;
using System.Fabric;
using System.Linq;
using System.Threading.Tasks;

using System.Fabric.Query;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FetchDataController : ControllerBase
    {
        private readonly IData data;
        private readonly FabricClient fc;
        public FetchDataController()
        {
            data = ServiceProxy.Create<IData>(new Uri("fabric:/ApiClientFabric/FetchData"));
            fc = new FabricClient();
        }

        [HttpGet]
        public async  Task<string> Get()
        {
            Console.WriteLine("----***** get data*****--------");
            return await data.HelloWorldAsync();
           
        }


        [HttpGet("data")]
        public async Task<ApplicationList> Getdata()
        {
            return await data.getData(fc);

        }
    }
}
