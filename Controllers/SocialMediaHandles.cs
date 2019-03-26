using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")] // api/socialmediahandle
    [ApiController]
    public class SocialMediaHandleController : ControllerBase
    {
        // GET api/socialmediahandle
        [HttpGet]
        public List<KeyValuePair<string, string>> Get()
        {
            var list = new List<KeyValuePair<string, string>>() { 
                new KeyValuePair<string, string>("Facebook", "https://facebook.com"),
                new KeyValuePair<string, string>("Github", "https://github.com"),
                new KeyValuePair<string, string>("Linkedin", "https://linkedin.com"),
                new KeyValuePair<string, string>("Gmail", "https://gmail.com")
            };

            return list;
        }
    }
}
