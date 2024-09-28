using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        /// <summary>
        /// Gets the length for the cube.
        /// </summary>
        /// <param name="UserInput">The length of the side of the cube.</param>
        /// <returns>
        /// The volume of the cube, calculated by multiplying the side length by itself three times.
        /// </returns>
        [HttpGet(template: "Cube/{UserInput}")]
        public int Cube(int UserInput)
        {
            int ResultNumber = UserInput * UserInput * UserInput;
            return Math.Abs(ResultNumber);
        }


    }
}
