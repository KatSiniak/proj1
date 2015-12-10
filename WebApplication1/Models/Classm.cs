using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Audio
    {
        public DateTime Songtime { get; set; }

        public TimeSpan Time
        {
            get
            {
                return DateTime.Now - Songtime;
            }
        }
    }
}