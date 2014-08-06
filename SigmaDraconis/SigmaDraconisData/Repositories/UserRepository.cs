using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SigmaDraconisData.Repositories
{
    class UserRepository
    {
        Context context;
        public UserRepository()
        {
            context = new Context();
        }
        public IEnumerable<User> GetAll()
        {
            return context.Users.ToList<User>();
        }

        public void Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public bool Delete(string username)
        {
            User user = context.Users.Find(username);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public User GetByName(string username)
        {
            return context.Users.Find(username);
        }
    }
}
