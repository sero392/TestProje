using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestProje.Models.DbModels;

namespace TestProje.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext()
        {
            Database.SetInitializer<BlogContext>(null);
        }

        public DbSet<Blog > Bloglar { get; set; }
    }
}