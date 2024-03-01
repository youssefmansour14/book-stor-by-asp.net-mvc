using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day3.Models
{
    public class ApplictionDbContext : DbContext
    {
        internal readonly object Books;

        public DbSet<Book>BOOks { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplictionDbContext() : base("DefaultConnection")
        {
            // Additional configuration if needed
        }

        public System.Data.Entity.DbSet<Day3.ViewModels.BookFormViewmodel> BookFormViewmodels { get; set; }
    }
}


