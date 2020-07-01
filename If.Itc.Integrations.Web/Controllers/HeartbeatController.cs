using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace If.Itc.Integrations.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeartbeatController : ControllerBase
    {
        // GET: api/Heartbeat
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Yo man!", DateTime.Now.ToString() };
        }

        
        // POST: api/Heartbeat
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
