using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Helper
{
    public class Help
    {
        public static List<Genres> AllGenres {
            get {
                return new List<Genres>
                {
                    Genres.Action,
                    Genres.Comedy,
                    Genres.Drama,
                    Genres.History,
                };
            }
        }
    }
}