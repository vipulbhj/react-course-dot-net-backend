using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")] // api/values
    [ApiController]
    public class BlogListController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public string[,] Get()
        {
            string[,] result = new string[2, 3] {
                {"1","My first Blog","In this blog, I talk about how to build react apps which can be extended to uses erver data later"},
                {"2","My Second Blog Post","In this blog, I will teach you how to connect apps to backend"}
            };
            return result;
        }
    }
}

