using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaDraconisData
{
    class Context : DbContext
    {
        public Context() : base("SigmaDraconis")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
