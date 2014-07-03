using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisModels
{
    public class Skill : IEntity
    {
        public string Name
        {
            get;
            set;
        }
        public string MorphedFrom
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
