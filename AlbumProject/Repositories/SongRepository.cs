using AlbumProject.Data;
using AlbumProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumProject.Repositories
{
    public class SongRepository : Repsository<Song>, IRepository<Song>
    {
        public SongRepository(ArtistContext Context) : base(context)
        {

        }
    }
}
