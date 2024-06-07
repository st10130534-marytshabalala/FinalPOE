using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace st101030534_part1_CLDV7111.Models
{
    public class MyViewModel
    {
        public List<Product> Products { get; set; }
        public List<Artisan> Artisans { get; set; }
        public Dictionary<Artisan, List<Product>> ArtisanProducts { get; set; }
    }


    }
