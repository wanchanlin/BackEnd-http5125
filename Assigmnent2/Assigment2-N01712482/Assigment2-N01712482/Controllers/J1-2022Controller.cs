using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assigment2_N01712482.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J1_2022Controller : ControllerBase
    {
        /// <summary>
        /// https://cemc.uwaterloo.ca/sites/default/files/documents/2022/2022CCCJrProblemSet.html
        /// GET:J1-2022/CupCakes
        /// </summary>
        /// <param name="small"></param> small box in put of 3 
        /// <param name="regular"></param>reglar box of input of 8
        /// <returns></returns>
        [HttpPost(template: "CupCakes")]
        [Consumes("application/x-www-form-urlencoded")]
        public string CupCakes([FromForm] int regular, [FromForm] int small)
        {
            if (small> 0 && regular > 0)
            {

                int student = 28;
                int totalCupCakes = small * 3 + regular * 8;
                int leftOver = totalCupCakes - student;
                return leftOver.ToString();
            }
            else
            {
                return "we can't have negative input";
            }
       
        }

    }
}
