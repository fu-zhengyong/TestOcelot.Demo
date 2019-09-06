using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TestOcelot.ClientService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "ClinetService-value1", "ClinetService-value2" };
        }
    }
}
