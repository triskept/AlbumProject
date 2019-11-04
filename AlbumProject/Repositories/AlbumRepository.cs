using AlbumProject.Data;
using AlbumProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumProject.Repositories;

namespace AlbumProject.Repositories
{
    public class AlbumRepository : Repository<Album>, IRepository<Album>
    {
        public AlbumRepository(ArtistContext context) : base(context)
        {

        }
    }
}
