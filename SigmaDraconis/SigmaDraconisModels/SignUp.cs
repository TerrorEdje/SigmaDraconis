using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisModels
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
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
