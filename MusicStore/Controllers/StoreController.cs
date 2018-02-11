using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            //Create mock list of Genres using Genre model
            var genres = new List<Genre>();

            for(int i = 1; i < 11; i++)
            {
                genres.Add(new Genre { Name = "Genre" + i.ToString() });
            }

            //pass the genres in the ViewBag
            //ViewBag.genres = genres;

            return View(genres);
        }

        // GET: Store/Details
        public ActionResult Details(string genre)
        {
            // check if genre is empty
            if (genre == null)
            {
                //return View("Error");
                return RedirectToAction("Index");
            }

            ViewBag.Genre = genre;

            // return mock album list
            var albums = new List<Album>();

            for (int i = 1; i < 4; i++)
            {
                albums.Add(new Album { Title = "Album" + i.ToString(), AlbumArtUrl = "/content/Images/placeholder.gif", AlbumPrice = 8.99 });
            }
            return View(albums);
        }
    }
}