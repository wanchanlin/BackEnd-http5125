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
        /// <returns>
        /// a senternce "Who's there?"
        /// </returns>
        [HttpPost(template: "knockknock")]
        public string knockknock()
        {
            return "Who's there?";
            
        }

    }
}
