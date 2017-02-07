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
    }
}
