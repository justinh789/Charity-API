using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CharityApp.Web.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {

        [HttpGet("Status")]
        public async Task<ActionResult<string>> Status()
        {
            return Ok("All is good!");
        }

    }
}
