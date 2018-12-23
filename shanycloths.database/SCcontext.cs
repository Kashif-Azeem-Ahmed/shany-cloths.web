using shanycloths.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shanycloths.database
{
    public class SCcontext : DbContext

    {

        public SCcontext() : base("ShanyClothsConnection")
        {

        }
        public DbSet<Category> categories { get; set; }
        public DbSet<product> products { get; set; }
    }
}
