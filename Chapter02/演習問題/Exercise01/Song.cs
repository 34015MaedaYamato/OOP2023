using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Song {
        public string Title { set; get; }
        public string ArtistName { get; set; }
        public int Length { get; set; }

        public Song(string title, string artistname, int length){
            Title = title;
            ArtistName = artistname;
            Length = length;
        }
    }
}
