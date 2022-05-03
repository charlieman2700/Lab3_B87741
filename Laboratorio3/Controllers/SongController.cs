using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Laboratorio3.Controllers
{
    public class SongController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            var favoriteSong = new Models.SongModel
            {
                Name = "Who am I",
                Artist = "Casting Crowns",
                Genre = "Worship",
                ReleasedYear = 2003,
                ImageUrl = "https://i.scdn.co/image/ab67616d0000b273b6b4afa5bec4ca0e9e586e2f"
            };
            ViewBag.MainTitle = "Favorite Song";

            return View(favoriteSong);
        }
    }
}
