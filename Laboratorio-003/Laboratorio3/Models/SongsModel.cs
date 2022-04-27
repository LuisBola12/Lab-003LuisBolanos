using System;
namespace Laboratorio3.Models
{
    public class SongsModel
    {
        public string FavSong { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public DateOnly ReleasedDate { get; set; }
        public string Genre { get; set; }
        public string YTLink { get; set; }

    }
}
