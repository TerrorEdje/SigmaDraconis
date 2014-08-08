using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisData.Models
{
    public class Topic : IEntity
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
        public string Title
        {
            get;
            set;
        }
        public int Active
        {
            get;
            set;
        }
        public int Hidden
        {
            get;
            set;
        }

        public virtual IList<Reply> Replies
        {
            get;
            set;
        }

        public virtual IList<PollOption> PollOptions
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
