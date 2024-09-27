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
        /// 
        /// </summary>
        /// <param name="dayInput"></param>
        /// <returns></returns>
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
