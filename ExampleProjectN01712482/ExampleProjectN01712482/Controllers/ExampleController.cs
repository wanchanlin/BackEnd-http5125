using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleProjectN01712482.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        // This is a code coment!
        //GOAL :
        // GET:localhost:XX/api/example -> "hello world"
        [HttpGet(template:"method1")]
        public string Method1() 
        {
            return "Hello World!";
        }
        // GOAL:
        //GET: local host:xx/api/example2-->"Hello 5125"
        [HttpGet(template:"method2")]

        public string Method2()
        {
            return "Hello 5125";
        }
        [HttpPost(template:"method3")]
        public string Method3() 
        {
            return "A Post Request";
        }

    }
}
