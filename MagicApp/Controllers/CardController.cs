using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicApiLib;
using Microsoft.AspNetCore.Mvc;
using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Model;

namespace MagicApp.Controllers
{
    [Route("api/Magic")]
    [ApiController]
    public class CardController : ControllerBase
    {
        Magic magicSender;
        public CardController()
        {
            magicSender = new Magic();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Card>> Get()
        {
            string[] _output;
            Exceptional<List<Card>> _aux;

            for(int i = 0, len = 10;i<len;i++)
            {

                _aux.Value.Concat0
            }
            
            for(int i = 0, len = _aux.Count(); i < len; i++)
            {
                _output.Append(_aux[i]);
            }
            return _output;
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
