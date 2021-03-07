using FetchData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FetchDataController : ControllerBase
    {
        private readonly IData data;
        public FetchDataController()
        {
           // data = ServiceProxy.Create<IData>(new Uri("fabric:/MyApplication/MyHelloWorldService"));
        }

        [HttpGet]
        public async  Task<string> Get()
        {
            return null;
           
        }
    }
}
