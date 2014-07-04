using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisModels
{
    public class PollOption : IEntity
    {
        public virtual IList<PollVote> PollVotes
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
    }
}
