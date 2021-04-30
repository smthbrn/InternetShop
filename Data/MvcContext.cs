using InternetShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace InternetShop.Data
{
    public class MvcContext : DbContext
    {
        public MvcContext(DbContextOptions<MvcContext> options): base(options)
           {
           }
            public Microsoft.EntityFrameworkCore.DbSet<Brand> Brand {get;set;}
            public Microsoft.EntityFrameworkCore.DbSet<Item> Item { get; set; }
            public Microsoft.EntityFrameworkCore.DbSet<Category> Category { get; set; }

            public Microsoft.EntityFrameworkCore.DbSet<Comment> Comments { get; set; }
    }
}
