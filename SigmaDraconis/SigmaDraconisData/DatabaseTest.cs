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
            context.Users.Add(new User() { Username = "Iseke", ESOUsername = "Iseke", Password = "password", Email ="edwinhattink@gmail.com"});
            try
            {
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }

            List<User> users = context.Users.ToList<User>();
            foreach(User user in users)
            {
                Console.WriteLine(user.Username);
            }

            Console.ReadLine();
        }
    }
}
