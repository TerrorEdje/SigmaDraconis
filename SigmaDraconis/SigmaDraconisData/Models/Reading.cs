using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisData.Models
{
    public class Reading : IEntity
    {
        public Reply Reply
        {
            get;
            set;
        }

        public User User
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }
    }
}
