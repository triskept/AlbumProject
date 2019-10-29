using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumProject.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
        public int Id { get; set; }

        ICollection<Album> Albums { get; set; }

        public Artist()
        {

        }
    }
}
