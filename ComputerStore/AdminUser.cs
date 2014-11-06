using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    public class AdminUser : User
    {
        /// <summary>
        /// Default Constructor of Admin User class
        /// </summary>
        public AdminUser()
        {

        }



        /// <summary>
        /// Password for admin user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool isAdminUser(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("admin"))
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Add valid Admin User to userlist
        /// </summary>
        /// <param name="user">User to be added.</param>
        public void AddAdminUser(User user)
        {

            List<User> usernamelist = new List<User>();


            usernamelist.Add(user);

            UserLogin login = new UserLogin();

            login.SerializeLogin(user);

        }

    }
}
