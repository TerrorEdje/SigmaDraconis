using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisModels
{
    public class Forum : IEntity
    {

        public virtual IList<Topic> Topics
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
