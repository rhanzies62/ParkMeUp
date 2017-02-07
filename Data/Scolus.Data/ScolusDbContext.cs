using Scolus.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolus.Data
{
    public class ScolusDbContext : DbContext
    {
        //TODO : Connection string
        public ScolusDbContext() : base("")
        {

        }

        public DbSet<School> Schools { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
