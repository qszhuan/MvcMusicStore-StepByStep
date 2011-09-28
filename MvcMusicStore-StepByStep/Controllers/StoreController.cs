using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore_StepByStep.Models;

namespace MvcMusicStore_StepByStep.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = new List<Genre>
                             {
                                 new Genre {Name = "Disco"},
                                 new Genre {Name = "Jazz"},
                                 new Genre {Name = "Rock"}
                             };
            
            return View(genres);
        }

        public ActionResult Browse(string genre)
        {
            var genre1 = new Genre() {Name = genre};

            return View(genre1);
        }

        public ActionResult Details(int id)
        {
            var album = new Album {Title = "Album " + id};

            return View(album);
        }

    }
}
