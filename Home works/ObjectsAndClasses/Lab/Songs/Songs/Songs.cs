using System;
using System.Collections.Generic;
using System.Text;

namespace Songs
{
    class Songs
    {
        public Songs(string listSongs, string nameSongs, string timeSongs)
        {
            this.ListSong = listSongs;
            this.NameSong = nameSongs;
            this.TimeSong = timeSongs;
        }
        public string ListSong { get; set; }
        public string NameSong { get; set; }
        public string TimeSong { get; set; }
    }
}
