using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {   /// <summary>
        /// 
        /// </summary>
        /// <param name="UserInput"></param>
        /// <returns></returns>
        [HttpGet(template: "Cube/{UserInput}")]
        public int Cube(int UserInput)
        {
            int ResultNumber = UserInput * UserInput * UserInput;
            return Math.Abs(ResultNumber);
        }


    }
}
