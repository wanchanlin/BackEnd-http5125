using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
     [HttpGet(template:"greeting")]
    public string greeting(string name)
        {
            string  userInput = name;
            return "Hi " + userInput+" !";

        }

    }
}
