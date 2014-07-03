using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisModels
{
    public class User : IEntity
    {

        public int Id
        {
            get;
            set;
        }
        public virtual IList<LoginLog> LoginLogs
        {
            get;
            set;
        }
    }
}
