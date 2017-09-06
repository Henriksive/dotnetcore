using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetcore_hoved.services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_hoved.Controllers
{
    [Route("api/[controller]")]
    public class MiddagController : Controller
    {
        private readonly IMiddagService _middagService;

        public MiddagController(IMiddagService middagService)
        {
            _middagService = middagService;
        }

        [HttpGet]
        [Route("random")]
        public JsonResult Random()
        {
            return Json(_middagService.GetRandom());
        }
    }
}