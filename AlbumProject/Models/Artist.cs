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
        public string Albums { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
        public int Id { get; set; }

        public Album Album { get; set; }
        public int AlbumId { get; set; }

        public Artist()
        {

        }
    }
}
