using Shopp.Data.Interfaces;
using Shopp.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shopp.Data.Repository
{
    public class UserRepository : IAllUsers
    {
        private readonly AppDBContent appDBContent;
        public static List<User> users;


        public UserRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
            users = appDBContent.User.ToList();
        }


        public User getUser(User us)
        {
            foreach (User u in users)
            {
                if ((u.email.Equals(us.email)) && (u.password.Equals(us.password))) {
                    return u;
                }
            }
            return null;
        }

            public bool createUser(User user)
            {
                List<User> isExist = appDBContent.User.Where(u => u.email.Equals(user.email)).ToList();

                if (isExist.Count != 0)
                {
                    return false;
                }
                else
                {
                    appDBContent.User.Add(user);
                    appDBContent.SaveChanges();
                    return true;
                }
            }

        }
    }
