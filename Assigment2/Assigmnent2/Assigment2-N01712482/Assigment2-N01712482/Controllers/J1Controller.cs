using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assigment2_N01712482.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class j1Controller : ControllerBase
    {   /// <summary>
        /// Calculates the total score based on deliveries and collisions.
        /// GET:J1/Delivedroid
        /// </summary>
        /// <param name="Collisions">The number of collisions. Each collision deducts 10 points.</param>
        /// <param name="Deliveries">The number of deliveries. Each delivery adds 50 points.</param>
        /// <returns>The total score, with a bonus of 500 points if deliveries exceed collisions.</returns>
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
