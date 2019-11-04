using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumProject.Data;
using AlbumProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlbumProject.Controllers
{
    [Route("api/artist")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private ArtistContext db;

        public ArtistController(ArtistContext db)
        {
            this.db = db;
        }

        //public ActionResult<IEnumerable<Artist>> all;

        // GET: api/Artist
        [HttpGet]
        public ActionResult<IEnumerable<Artist>> Get()
        {
            return db.Artists;
        }

        // GET: api/Artist/5
        //[HttpGet("{id}")]
        //public ActionResult<Artist> Get(int id)
        //{
        //    return ;
        //}

        // POST: api/Artist
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Artist/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
