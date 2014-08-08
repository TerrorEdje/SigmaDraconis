using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisData.Models
{
    public class Reply : IEntity
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
        public string Content
        { 
            get; 
            set; 
        }
        public virtual IList<User> ReadBy
        {
            get;
            set;
        }
        public DateTime PostedOn
        {
            get;
            set;
        }
        public DateTime EditedAt
        {
            get;
            set;
        }

    }
}
