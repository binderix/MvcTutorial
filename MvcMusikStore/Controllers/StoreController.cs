using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;


namespace MvcMusicStore.Content
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();
        
        //
        // GET: /Store/

        public ActionResult Index()
        {
            //SampleData sd = new SampleData();
            //sd.InitializeDatabase(storeDB);
            //storeDB.SaveChanges();


            var genres = storeDB.Genres.ToList();
           

            //var genres = new List<Genre>
            //{
            //    new Genre { Name = "Disco" },
            //    new Genre { Name = "Playing for Change"},
            //    new Genre { Name = "native american shamanic music"},
            //    new Genre { Name = "Forroh"}
            //};

            return View(genres);
        }

        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };

            return View(genreModel);
        }

    }
}
