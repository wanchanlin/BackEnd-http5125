using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assigment2_N01712482.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J2Controller : ControllerBase
    {   /// <summary>
        ///  /// GET:j2/ChiliPeppers
        /// </summary>
        /// <param name="Ingredients"></param> The different chili names of ingredients 
        /// </returns>
        /// 
        [HttpGet(template: "ChiliPeppers")]
        public int ChiliPeppers([FromQuery] string Ingredients)
        {
            
          var pepperShu = new Dictionary<string, int>
    {
        { "Poblano", 1500 },
        { "Mirasol", 6000 },
        { "Serrano", 15500 },
        { "Cayenne", 40000 },
        { "Thai", 75000 },
        { "Habanero", 125000 }
    };

           
            if (string.IsNullOrWhiteSpace(Ingredients))
            {
                return 0; 
            }

            
            var pepperList = Ingredients.Split(',').Select(p => p.Trim()).ToList();

           
            int totalShu = pepperList.Sum(pepper => pepperShu.GetValueOrDefault(pepper, 0));

            return totalShu;
        }

    }
}
