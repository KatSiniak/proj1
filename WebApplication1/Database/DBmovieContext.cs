using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Database
{
    public class DBmovieContext : DbContext
    {
        public DBmovieContext():base("DefaultConnection")
        {
        }

        public DbSet<Film> Films { get; set; }

    }
}