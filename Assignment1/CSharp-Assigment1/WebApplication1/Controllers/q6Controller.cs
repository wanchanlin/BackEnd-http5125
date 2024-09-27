<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="side"></param>
        /// <returns></returns>
        [HttpGet("Hexagon")]
        public double Hexagon(double side)
        {
            double result = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return result;
        }
    }
}
=======
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="side"></param>
        /// <returns></returns>
        [HttpGet("Hexagon")]
        public double Hexagon(double side)
        {
            double result = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return result;
        }
    }
}
>>>>>>> 94994292fa6783b27d873001d5486fa6ef59253d
