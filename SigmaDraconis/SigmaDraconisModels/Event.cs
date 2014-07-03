using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisModels
{
    public class Event : IEntity
    {
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
        public DateTime Start
        {
            get;
            set;
        }
        public IList<SignUp> SignUps
        {
            get;
            set;
        }
        
    }
}
