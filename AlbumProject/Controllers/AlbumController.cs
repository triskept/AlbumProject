using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumProject.Data;
using AlbumProject.Models;
using AlbumProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlbumProject.Controllers
{
    [Route("api/album")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private IRepository<Album> albumRepo;

        public AlbumController(IRepository<Album> albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        // GET api/Albums
        [HttpGet]
        public IEnumerable<Album> Get()
        {
            return albumRepo.GetAll();
        }

        // GET api/Albums/5
        [HttpGet("{id}")]
        public Album Get(int id)
        {
            return albumRepo.GetById(id);
        }

        // POST api/Albums
        [HttpPost]
        public IEnumerable<Album> Post([FromBody] Album album)
        {
            albumRepo.Create(album);
            return albumRepo.GetAll();

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
