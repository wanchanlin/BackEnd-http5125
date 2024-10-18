using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assigment2_N01712482.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class j1Controller : ControllerBase
    {   /// <summary>
        /// 
        /// </summary>
        /// <param name="Collisions"></param>
        /// <param name="Deliveries"></param>
        /// <returns></returns>
        [HttpPost(template: "Delivedroid")]
        [Consumes("application/x-www-form-urlencoded")]
        
        public int Delivedroid([FromForm]int Collisions, [FromForm]int Deliveries)
        {
            if (Deliveries > Collisions)
            {
                int sum = Deliveries * 50 - Collisions * 10 + 500;
                return sum;
            }
            else {
                int sum = Deliveries * 50 - Collisions * 10;
                return sum;
            }
          
        }
    }
}
