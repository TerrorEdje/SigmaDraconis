using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisData
{
    public class SignUp : IEntity
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

        public Role Role
        {
            get;
            set;
        }

        
    }
}
