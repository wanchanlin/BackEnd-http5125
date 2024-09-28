using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class q1Controller : ControllerBase
    {
        /// <summary>
        /// Starts a process that returns a string.
        /// </summary>
        /// <returns>
        /// A string sentence.
        /// </returns>


        [HttpGet(template: "Welcome")]
        public string Welcome() 
        {
            return "Welcome to 5125!";
        }

    }
}
