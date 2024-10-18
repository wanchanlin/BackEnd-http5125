﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assigment2_N01712482.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J2Controller : ControllerBase
    {   /// <summary>
        /// 
        /// </summary>
        /// <param name="Ingredients"></param>
        /// <returns></returns>
        /// 
        [HttpGet(template: "ChiliPeppers")]
        public int ChiliPeppers([FromQuery] string Ingredients)
        {
            // Dictionary with pepper names and their SHU values
          var pepperShu = new Dictionary<string, int>
    {
        { "Poblano", 1500 },
        { "Mirasol", 6000 },
        { "Serrano", 15500 },
        { "Cayenne", 40000 },
        { "Thai", 75000 },
        { "Habanero", 125000 }
    };

            // Check if Ingredients is null or empty
            if (string.IsNullOrWhiteSpace(Ingredients))
            {
                return 0; // Return 0 if no ingredients were provided
            }

            // Split Ingredients into an array of pepper names
            var pepperList = Ingredients.Split(',').Select(p => p.Trim()).ToList();

            // Calculate the total spiciness (SHU)
            int totalShu = pepperList.Sum(pepper => pepperShu.GetValueOrDefault(pepper, 0));

            return totalShu;
        }

    }
}