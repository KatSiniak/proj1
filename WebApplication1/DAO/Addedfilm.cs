using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.DAO
{
    public class Addedfilm
    {
        public static void Saver(Film add)
        {
            using (var db = new DBmovieContext())
            {
                db.Films.Add(add);
                db.SaveChanges();
            }
        }

        public static List<Film> AllFilms()
        {
            using (var db = new DBmovieContext())
            {
                return db.Films.ToList();
            }
        }

        public static void Delete(int del)
        {
            using (var db = new DBmovieContext())
            {
                var delmovie = db.Films.First(x => x.Id == del);
                db.Films.Remove(delmovie);
                db.SaveChanges();
            }
        }
    }
}