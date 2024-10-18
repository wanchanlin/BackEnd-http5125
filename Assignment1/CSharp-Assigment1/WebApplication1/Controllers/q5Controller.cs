using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {

        /// <summary>
        /// Generates a sentence containing the specified secret number.
        /// </summary>
        /// <param name="secretNumber">The secret number to include in the sentence.</param>
        /// <returns>
        /// A sentence containing the secret number.
        /// </returns>

        [HttpPost(template: "Secret")]
        [Consumes("application/json")]
        public string Secret([FromBody] int number)
        {
            return $"Shh.. the secret is {number}";
        }



    }
}
