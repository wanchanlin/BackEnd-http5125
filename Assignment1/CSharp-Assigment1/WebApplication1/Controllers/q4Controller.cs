<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {   /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost(template: "knockknock")]
        public string knockknock()
        {
            return "Who's there?";
            
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
    public class q4Controller : ControllerBase
    {   /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost(template: "knockknock")]
        public string knockknock()
        {
            return "Who's there?";
            
        }

    }
}
>>>>>>> 94994292fa6783b27d873001d5486fa6ef59253d
