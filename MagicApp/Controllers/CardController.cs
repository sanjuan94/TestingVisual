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
        public async Task<List<string>> Get()
        {
            List<string> _output = new List<string>();
            Exceptional<List<Card>> _data = new Exceptional<List<Card>>();
            try
            {
                _data = await magicSender.GetCardsPage(1, 20);
                /*
                for (int i = 2, len = 10; i < len; i++)
                {
                    var _aux = await magicSender.GetCardsPage(i, 20);

                    _data.Value.Concat(_aux.Value);
                }*/

                for (int i = 0, len = _data.Value.Count; i < len; i++)
                {
                    _output.Add(_data.Value[i].Name);
                }
                return _output;
            }
            catch(Exception ex)
            {
               
                throw ex;
            }
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
