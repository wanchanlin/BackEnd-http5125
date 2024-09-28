using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        /// <summary>
        /// Takes the current date and adds or subtracts a specified number of days.
        /// </summary>
        /// <param name="days">The number of days to add (positive) or subtract (negative) from today's date.</param>
        /// <returns>
        /// The resulting date after adding or subtracting the specified number of days from today.
        /// </returns>

        [HttpGet(template: "Timemachine")]
        public string Timemachine( int days)
        {
            DateTime today = DateTime.Today;

            DateTime result = today.AddDays(days);
           
            string formattedDate = result.ToString("yyyy/MM/dd");

            
            Console.WriteLine(formattedDate);

            return formattedDate;
        }


    }
}
