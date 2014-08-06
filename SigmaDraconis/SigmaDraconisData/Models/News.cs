using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisData
{
    public class News : IEntity
    {
        public User By
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public int Hidden
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public string Context
        {
            get;
            set;
        }
        public DateTime PostedOn
        {
            get;
            set;
        }
    }
}
