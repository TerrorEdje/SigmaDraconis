using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisModels
{
    public class Category : IEntity
    {

        public virtual IList<Forum> Forums
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
