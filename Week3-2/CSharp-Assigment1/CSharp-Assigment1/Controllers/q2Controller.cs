using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
   
    public class q2Controller : ControllerBase
    {
        /// <summary>
        /// Get string"name"
        /// </summary>
        /// <param name="name"></param>
        /// <returns>
        /// one sentance hi + name
        /// </returns>
     [HttpGet(template:"greeting")]
    public string greeting(string name)
        {
            string  userInput = name;
            return "Hi " + userInput+" !";

        }

    }
}
