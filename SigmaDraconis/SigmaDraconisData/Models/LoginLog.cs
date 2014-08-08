using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisData.Models
{
    public class LoginLog : IEntity
    {
        public int Id
        {
            get;
            set;
        }
        public DateTime Time
        {
            get;
            set;
        }
    }
}
