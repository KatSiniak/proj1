using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Genres genres { get; set; }

        public DateTime Created { get; set; }

        public static List<Genres> AllGenres {
            get {
                var a = new List<Genres>();
                a.Add(Genres.Comedy);
                a.Add(Genres.Drama);
                a.Add(Genres.Action);
                a.Add(Genres.History);
                return a;
            }
        }
       
    }
    public enum Genres
    {
        Drama,
        Comedy,
        Action,
        History
    }
}