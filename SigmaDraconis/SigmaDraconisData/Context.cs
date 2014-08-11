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

        public DbSet<Rank> Ranks { get; set; }

        public DbSet<SigmaDraconisData.Models.Application> Applications { get; set; }

        public DbSet<Build> Builds { get; set; }
        
        public DbSet<Category> Category { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<LoginLog> LoginLog { get; set; }

        public DbSet<PollOption> PollOptions { get; set; }

        public DbSet<Reading> Readings { get; set; }

        public DbSet<SignUp> SignUps { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<SkillBar> SkillBars { get; set; }
    }
}
