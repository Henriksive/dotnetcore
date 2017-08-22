using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore.Controllers
{
    [Route("api/[controller]")]
    public class PingController : Controller
    {
        // Ping
        [HttpGet]
        public string Pong()
        {
            return "Pong";
        }
    }
}
