using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AlbumProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        // GET api/Albums
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Albums1", "Albums2" };
        }

        // GET api/Albums/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Albums";
        }

        // POST api/Albums
        [HttpPost]
        public void Post([FromBody] string Albums)
        {
        }

        // PUT api/Albums/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string Albums)
        {
        }

        // DELETE api/Albums/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
