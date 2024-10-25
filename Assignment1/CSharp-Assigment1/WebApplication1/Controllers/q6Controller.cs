using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        /// <summary>
        /// Retrieves a number and applies a formula to it.
        /// </summary>
        /// <param name="side">The input number to be used in the formula.</param>
        /// <returns>
        /// The result obtained from applying the formula to the input number.
        /// </returns>


        [HttpGet(template:"Hexagon")]
        public double Hexagon(double side)
        {
            double result = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return result;
        }
    }
}
