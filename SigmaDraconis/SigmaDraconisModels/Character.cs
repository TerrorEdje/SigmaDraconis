using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisModels
{
    public class Character : IEntity
    {
        public string Name
        {
            get;
            set;
        }
        public User User
        {
            get;
            set;
        }

        public Alliance Alliance
        {
            get;
            set;
        }

        public Class Class
        {
            get;
            set;
        }

        public Race Race
        {
            get;
            set;
        }

        public Build Build
        {
            get;
            set;
        }

        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
