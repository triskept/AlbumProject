using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumProject.Data;
using AlbumProject.Models;
using AlbumProject.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlbumProject.Controllers
{
    [Route("api/artist")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private IRepository<Artist> artistRepo;

        public ArtistController(IRepository<Artist> artistRepo)
        {
            this.artistRepo = artistRepo;
        }

        // GET: api/Artist
        [HttpGet]
        public IEnumerable<Artist> Get()
        {
            return artistRepo.GetAll();
        }

        // GET: api/Artist/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "artist";
        }

        // POST: api/Artist
        [HttpPost]
        public IEnumerable<Artist> Post([FromBody] Artist artist)
        {
            artistRepo.Create(artist);
            return artistRepo.GetAll();
        }

        // PUT: api/Artist/5
        [HttpPut("{id}")]
        public IEnumerable<Artist> Put([FromBody] Artist artist)
        {
            artistRepo.Update(artist);
            return artistRepo.GetAll();

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<Artist> Delete(int id)
        {
            var deleteArtist = artistRepo.GetById(id);
            artistRepo.Delete(deleteArtist);
            return artistRepo.GetAll();
        }
    }
}
