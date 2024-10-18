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
        /// <summay>
        /// get input 
        /// </summary>
        /// <param name="days"></param>
        /// <returns>
        /// get
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
