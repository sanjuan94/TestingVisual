using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicApiLib;
using Microsoft.AspNetCore.Mvc;

namespace MagicApp.Controllers
{
    [Route("api/Magic")]
    [ApiController]
    public class CardController : ControllerBase
    {
        public CardController()
        {
            Magic magicSender = new Magic();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"",""};
        }

        // GET api/values/5
        [HttpGet("SearchCard")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
