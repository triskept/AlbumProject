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
    [Route("api/song")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private IRepository<Song> songRepo;

        public SongController(IRepository<Song> songRepo)
        {
            this.songRepo = songRepo;
        }

        // GET: api/Song
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return songRepo.GetAll();
        }

        // GET: api/Song/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Song
        [HttpPost]
        public IEnumerable<Song> Post([FromBody] Song song)
        {
            songRepo.Create(song);
            return songRepo.GetAll();

        }

        // PUT: api/Song/5
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
