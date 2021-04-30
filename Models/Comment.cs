using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public String Text { get; set; }

        public String Author { get; set; }

        public DateTime Date { get; set; }

        public Item item { get; set; }
    }
}
