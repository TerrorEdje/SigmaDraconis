using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisModels
{
    public class Build : IEntity
    {
        public int Health
        {
            get;
            set;
        }
        public int Stamina
        {
            get;
            set;
        }
        public int Magicka
        {
            get;
            set;
        }
        public virtual IList<Skill> BarOne
        {
            get;
            set;
        }
        public virtual IList<Skill> BarTwo
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
