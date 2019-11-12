using AlbumProject.Data;
using AlbumProject.Models;
using AlbumProject.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumProject.Repositories
{
    public class ArtistRepository : Repository<Artist>, IRepository<Artist>
    {
        private DbContext db;

        public ArtistRepository(ArtistContext context) : base(context)
        {
            this.db = context;
        }

        public override Artist GetById(int id)
        {
            return db.Set<Artist>().Where(i => i.Id == id).Include("Albums").FirstOrDefault();
        }
    }
}
