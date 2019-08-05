using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Model {
    public class PlutoContext : DbContext {
        public DbSet <Author> Authors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Cover> Covers { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
