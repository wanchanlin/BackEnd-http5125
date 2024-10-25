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
        /// Calculates the number of leftover cupcakes after distributing them to students.
        /// GET:J1-2022/CupCakes
        /// <remarks>
        /// This method is based on a scenario where a certain number of cupcakes are packed in small and regular boxes:
        /// - A small box contains 3 cupcakes.
        /// - A regular box contains 8 cupcakes.
        /// The total number of cupcakes is calculated, and then the method computes how many are left after distributing 28 cupcakes to students. If either the small or regular box input is less than or equal to zero, an error message is returned indicating that negative input is not allowed.
        /// This method is inspired by the problem set from the Canadian Computing Competition Junior 2022.
        /// </remarks>
        /// <param name="small">The number of small boxes, each containing 3 cupcakes.</param>
        /// <param name="regular">The number of regular boxes, each containing 8 cupcakes.</param>
        /// <returns>
        /// A string representing the number of leftover cupcakes after distributing 28 cupcakes to students, or an error message if the input is invalid.
        /// </returns>
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
