using SigmaDraconisData.Models;
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
        public Context()
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<News> News { get; set; }

        public DbSet<Reply> Replies { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Forum> Forums { get; set; } 
    }
}
