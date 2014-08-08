using SigmaDraconisData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaDraconisData
{
    class DatabaseTest
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.Users.Add(new User() { Username = "Iseke", ESOUsername = "Iseke", Password = "password"});
            context.SaveChanges();

            List<User> users = context.Users.ToList<User>();
            foreach(User user in users)
            {
                Console.WriteLine(user.Username);
            }

            Console.ReadLine();
        }
    }
}
