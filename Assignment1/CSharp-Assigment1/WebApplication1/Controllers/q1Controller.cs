<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class q1Controller : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet(template: "Welcome")]
        public string Welcome() 
        {
            return "Welcome to 5125!";
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
   
    public class q1Controller : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet(template: "Welcome")]
        public string Welcome() 
        {
            return "Welcome to 5125!";
        }

    }
}
>>>>>>> 94994292fa6783b27d873001d5486fa6ef59253d
