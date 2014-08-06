using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisData
{
    public class User : IEntity
    {

        public int Id
        {
            get;
            set;
        }
        public string Username
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public string PasswordTemp
        {
            get;
            set;
        }
        public string Code
        {
            get;
            set;
        }
        public int Active
        {
            get;
            set;
        }
        public string Signature
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string ESOUsername
        {
            get;
            set;
        }

        public IList<Reply> HasRead
        {
            get;
            set;
        }

    }
}
