using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace st101030534_part1_CLDV7111.Models
{
    public class Product
    {

            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public Artisan Artisan { get; set; }
        public int Id { get; set; } // Add Id property here
        
        // Other properties...

    }

}
