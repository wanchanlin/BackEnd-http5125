using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assigment2_N01712482.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class j1Controller : ControllerBase
    {   /// <summary>
        /// GET:J1/Delivedroid
        /// </summary>
        /// <param name="Collisions"></param> score for -10 per points
        /// <param name="Deliveries"></param> score for 50 per points
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
