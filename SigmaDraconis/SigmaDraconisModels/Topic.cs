using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisModels
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
    }
}
