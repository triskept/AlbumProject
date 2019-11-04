using AlbumProject.Data;
using AlbumProject.Models;
using AlbumProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumProject.Repositories
{
    public class SongRepository : Repository<Song>, IRepository<Song>
    {
        public SongRepository(ArtistContext context) : base(context)
        {

        }
    }
}
