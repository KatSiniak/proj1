using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAO;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Index(Indexer info)
        {
            Response.Cookies["Name"].Value = info.Name;
            Response.Cookies["Age"].Value = info.Age;



            return RedirectToAction("Index");
        }


   
        public ActionResult Index()
        {

            return View();
        }

        public List<Film> GetAllFilmsOld()
        {
            List<Film> films = new List<Film>();

            var film = new Film
            {
                Name = "The man from U.N.C.L.E",
                genres = Genres.Action,
                Created = new DateTime(2007, 5, 18)
            };

            films.Add(film);

            film = new Film
            {

                Created = new DateTime(2009, 2, 15),
                genres = Genres.Drama,
                Name = "The Ant-Man"
            };
            films.Add(film);

            return films;
        }

        public ActionResult Comment()
        {
            return View();
        }

        public ActionResult Comments()
        {
            var comments = Session["comments"] as List<Comment>;

            return View(comments);
        }


        [HttpPost]
        public ActionResult Comment(Comment comment)
        {
         var comments =   Session["comments"] as List<Comment>;
            if (comments == null)
            { comments = new List<Comment>(); }
            comments.Add(comment);
            Session["comments"] = comments;

            return RedirectToAction("Comments");
        }

        public ActionResult About()
        {
            var time = new Audio();
            time.Songtime = new DateTime(2015,02,05);
           
            ViewBag.Message = "Your application description page.";

            return View(time);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Image()
        {
            return View();
        }

        public ActionResult Films()
        {
             return View(Addedfilm.AllFilms());
        }

        [HttpPost]
        public ActionResult Films(Models.Filter filter)
        {
            var model = new List<Film>();
            if (filter == null)
            {
                model = GetAllFilms();
            }
            else
            {
                model = GetAllFilms();
                model = model.Where(x => x.genres == filter.genres || x.Created < filter.created).ToList();
            }

            return View("Films", model);
        }


        // фильтрация фильмов   
        public ActionResult Filters()
        {
            return View();
        }



        private List<Film> GetAllFilms()
        {
            using (var db = new DBmovieContext())
            {
                return db.Films.ToList();

            }
        }

        public ActionResult Filter(Models.Filter filter)
        {
            return View();
        }


        public ActionResult AddFilm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFilm(Film film)
        {
            Addedfilm.Saver(film);
            return RedirectToAction("Films");

        }


        public ActionResult Remove(int IDdel)
        {
            Addedfilm.Delete(IDdel);
            return RedirectToAction("Films");
        }


    }
}
