<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
       
        /// </summary>
        /// <param name="number"></param>
        /// <returns>
        /// A sentance sentance with a the secrete number
        /// </returns> [Consumes("application/json")]
        public string Secret([FromBody] int number)
        {
            return $"Shh.. the secret is {number}";
        }



    }
}
=======
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
       
        /// </summary>
        /// <param name="number"></param>
        /// <returns>
        /// A sentance sentance with a the secrete number
        /// </returns> [Consumes("application/json")]
        public string Secret([FromBody] int number)
        {
            return $"Shh.. the secret is {number}";
        }



    }
}
>>>>>>> 94994292fa6783b27d873001d5486fa6ef59253d