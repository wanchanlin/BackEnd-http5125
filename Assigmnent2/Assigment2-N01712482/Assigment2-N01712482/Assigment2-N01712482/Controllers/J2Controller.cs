using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assigment2_N01712482.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J2Controller : ControllerBase
    {   /// <summary>
        /// GET:j2/ChiliPeppers
        /// Calculates the total Scoville Heat Units (SHU) based on the provided list of chili pepper names.
        // <remarks>
        /// This method takes a comma-separated string of chili pepper names as input and returns the total combined Scoville Heat Units (SHU) for those peppers. 
        /// The peppers and their respective SHU values are:
        /// - Poblano: 1,500 SHU
        /// - Mirasol: 6,000 SHU
        /// - Serrano: 15,500 SHU
        /// - Cayenne: 40,000 SHU
        /// - Thai: 75,000 SHU
        /// - Habanero: 125,000 SHU
        /// If a pepper in the input is not in the predefined list, it is ignored, and its SHU value is considered 0. 
        /// The method returns 0 if the input string is empty or only contains whitespace.
        /// </remarks>
        /// <param name="Ingredients">A comma-separated string representing the names of chili peppers.</param>
        /// <returns>
        /// The total SHU value of all valid peppers in the input string. Returns 0 if no valid peppers are provided.
        /// </returns>

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
