using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaDraconisData.Models
{
    class Application : IEntity
    {
        public int Id
        {
            get;
            set;
        }
        public User User
        {
            get;
            set;
        }
        public string Content
        {
            get;
            set;
        }
        public int Status
        {
            get;
            set;
        }
    }
}
