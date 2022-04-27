using Laboratorio3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio3.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            var song = GetFavoriteSong();
            ViewBag.MainTitle = "My Favorite Song";
            return View(song);
        }

        private SongsModel GetFavoriteSong()
        {
            SongsModel song = new SongsModel {FavSong = "Without Me",Artist = "Eminem",Album = "The Eminem Show",
                ReleasedDate = new DateOnly(2002,5,13),Genre = "Hip-Hop/Rap",YTLink = "https://www.youtube.com/watch?v=YVkUvmDQ3HY&ab_channel=EminemVEVO" };

            return song;
        }
    }
}
