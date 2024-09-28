using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
   
    public class q2Controller : ControllerBase
    {
        /// <summary>
        /// Returns a greeting message using the provided name.
        /// </summary>
        /// <param name="name">The name to be included in the greeting.</param>
        /// <returns>
        /// A single sentence that says "Hi" followed by the provided name.
        /// </returns>

        [HttpGet(template:"greeting")]
    public string greeting(string name)
        {
            string  userInput = name;
            return "Hi " + userInput+" !";

        }

    }
}
