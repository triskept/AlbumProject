using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumProject.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Songs { get; set; }
        public string Label { get; set; }

        public Song Song { get; set; }
        public int SongId { get; set; }

        ICollection<Artist> Artists { get; set; }

        public Album()
        {

        }
    }
}
