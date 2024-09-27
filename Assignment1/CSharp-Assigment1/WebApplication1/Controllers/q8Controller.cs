<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {   /// <summary>
        /// 
        /// </summary>
        /// <param name="smallInput"></param>
        /// <param name="largeInput"></param>
        /// <returns></returns>

        [HttpPost(template: "squashfellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public string squashfellows([FromForm] int small, [FromForm] int large)
        {  
            double smallPrice = 25.50;
            double largePrice = 40.50;
            // Example calculation based on the inputs
            double smallTotal = Math.Round(smallPrice * small, 2);
            double largeToal = Math.Round(largePrice * large, 2);
            double Subtotal = smallTotal + largeToal;
            double Tax = Math.Round(Subtotal * 0.13, 2);
            double Total = Subtotal + Tax;
            
            string smallTotalResult = smallTotal.ToString("C", CultureInfo.CurrentCulture);
            string largeTotalResult = largeToal.ToString("C", CultureInfo.CurrentCulture);
            string subtotalResult = Subtotal.ToString("C", CultureInfo.CurrentCulture);
            string taxResult = Tax.ToString("C", CultureInfo.CurrentCulture);
            string totalResult = Total.ToString("C", CultureInfo.CurrentCulture);

            return small + " Small @ $25.50 = " + smallTotalResult +"; "+large+ " large @ $40.50 = " + largeTotalResult + "; Subtotal = " + subtotalResult +"; Tax = $" + taxResult + " HST ; Total = " + totalResult;
        }

    }
}
=======
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {   /// <summary>
        /// 
        /// </summary>
        /// <param name="smallInput"></param>
        /// <param name="largeInput"></param>
        /// <returns></returns>

        [HttpPost(template: "squashfellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public string squashfellows([FromForm] int small, [FromForm] int large)
        {  
            double smallPrice = 25.50;
            double largePrice = 40.50;
            // Example calculation based on the inputs
            double smallTotal = Math.Round(smallPrice * small, 2);
            double largeToal = Math.Round(largePrice * large, 2);
            double Subtotal = smallTotal + largeToal;
            double Tax = Math.Round(Subtotal * 0.13, 2);
            double Total = Subtotal + Tax;
            
            string smallTotalResult = smallTotal.ToString("C", CultureInfo.CurrentCulture);
            string largeTotalResult = largeToal.ToString("C", CultureInfo.CurrentCulture);
            string subtotalResult = Subtotal.ToString("C", CultureInfo.CurrentCulture);
            string taxResult = Tax.ToString("C", CultureInfo.CurrentCulture);
            string totalResult = Total.ToString("C", CultureInfo.CurrentCulture);

            return small + " Small @ $25.50 = " + smallTotalResult +"; "+large+ " large @ $40.50 = " + largeTotalResult + "; Subtotal = " + subtotalResult +"; Tax = $" + taxResult + " HST ; Total = " + totalResult;
        }

    }
}
>>>>>>> 94994292fa6783b27d873001d5486fa6ef59253d