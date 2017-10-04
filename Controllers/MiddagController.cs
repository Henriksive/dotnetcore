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
        private readonly IDatabaseService _databaseService;

        public MiddagController(IMiddagService middagService, IDatabaseService databaseService)
        {
            _middagService = middagService;
            _databaseService = databaseService;
        }

        [HttpGet]
        [Route("random")]
        public JsonResult Random()
        {
            return Json(_middagService.GetRandom());
        }

        [HttpGet]
        [Route("db")]
        public JsonResult DB()
        {
            return Json(_databaseService.GetSomething());
        }
    }
}