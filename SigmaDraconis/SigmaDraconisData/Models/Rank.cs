using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisData.Models
{
    public class Rank : IEntity
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public IList<Forum> AllowedTo
        {
            get;
            set;
        }
        
        public IList<User> Users
        {
            get;
            set;
        }
    }
}
