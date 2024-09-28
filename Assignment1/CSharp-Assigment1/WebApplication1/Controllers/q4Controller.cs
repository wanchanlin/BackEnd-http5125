using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        /// <summary>
        /// Returns a sentence asking "Who's there?".
        /// </summary>
        /// <returns>
        /// A sentence: "Who's there?".
        /// </returns>

        [HttpPost(template: "knockknock")]
        public string knockknock()
        {
            return "Who's there?";
            
        }

    }
}
