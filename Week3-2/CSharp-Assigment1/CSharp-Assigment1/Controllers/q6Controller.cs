using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        /// <summary>
        /// Get number 
        /// </summary>
        /// <param name="side"></param>
        /// User the mathematic way to use funtion get thenumber
        /// <returns>
        /// Result get the formulate
        /// </returns>
        
        [HttpGet(template:"Hexagon")]

        public double Hexagon(double side)
        {
            double result = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return result;
        }
    }
}
