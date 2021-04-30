using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class Item
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public int Quanitity { get; set; }

        public  Category category { get; set; }

        public ICollection<Comment> comments { get; set; }
    }
}
