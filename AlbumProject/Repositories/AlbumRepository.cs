using AlbumProject.Data;
using AlbumProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumProject.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AlbumProject.Repositories
{
    public class AlbumRepository : Repository<Album>, IRepository<Album>
    {
            private DbContext db;

        public AlbumRepository(ArtistContext context) : base(context)
        {
            this.db = context;
        }

        public override Album GetById(int id)
        {
            return db.Set<Album>().Where(i => i.Id == id).Include("Songs").FirstOrDefault();
        }
    }
    
}
