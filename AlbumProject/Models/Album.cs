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
        public string Label { get; set; }

        public virtual Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }

        public virtual ICollection<Song> Songs { get; set; }

        public Album()
        {

        }
    }
}
