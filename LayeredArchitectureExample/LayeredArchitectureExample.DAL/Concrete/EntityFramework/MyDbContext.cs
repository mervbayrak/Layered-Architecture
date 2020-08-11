using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LayeredArchitectureExample.Entities.Concrete;

namespace LayeredArchitectureExample.DAL.Concrete.EntityFramework
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base ("name=MyConnectionString")
        {

        }
        public DbSet<User> User { get; set; }
    }
}
