using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisModels
{
    public class PollVote : IEntity
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
    }
}
