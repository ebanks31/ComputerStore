using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ComputerStore
{
    /// <summary>
    /// This class contain information related to the User of the program.
    /// </summary>
    [Serializable]
    public class User
    {

        private string username="";
        private string password = "";
        public static User currentuser;
        public static List<User> userlist;
        /// <summary>
        /// Username property
        /// </summary>
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        /// Password Property
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        /// <summary>
        /// Default Constructor of User class
        /// </summary>
        public User()
        {
            

        }
        
        
        
        /// <summary>
        /// Overloaded Constructor of User class. Just sets Username.
        /// </summary>
        /// <param name="username">Username of user</param>
        /// <param name="password">Password of user</param>
        public User(string username)
        {
            Username = username;

        }

        /// <summary>
        /// Overloaded Constructor of User class. Set Username and Password
        /// </summary>
        /// <param name="username">Username of user</param>
        /// <param name="password">Password of user</param>
        public User(string username, string password)
        {
            Username = username;
            Password = password;

        }



        /// <summary>
        /// Adds valid User to userlist
        /// </summary>
        /// <param name="user">User to be added.</param>
        public void AddUser(User user)
        {

            List<User> usernamelist = new List<User>();


            usernamelist.Add(user);

            UserLogin login = new UserLogin();

             List<User> serializeduserlist = login.DeserializeLogin();

             bool usercheck = login.CheckValidUser(user, serializeduserlist);

            //Check to make sure it does not add duplicate users.
             if (usercheck == false)
             {
                 login.SerializeLogin(user);
             }
             else
             {
                 //Do Nothing
             }

        }

        /// <summary>
        /// Removes user from the userlist
        /// </summary>
        /// <param name="user">User to be added</param>
        /// <param name="userlist">Userlist from file</param>
        /// <returns>Final list of user after removal</returns>
        public List<User> removeUser(User user, List<User> userlist)
        {
            List<User> Userlisttemp = new List<User>();
            int i = 0;
            foreach(User users in userlist)
            {
                string username = user.Username;
                string listuser = users.Username;

                if (username.Equals(listuser))
                {
                    //Do nothing

                }
                else
                {
                    Userlisttemp.Add(users);
                    i++;
                }
            }
            return Userlisttemp;

        }

        /// <summary>
        /// Get Current User from a List of users
        /// </summary>
        /// <param name="username">Username of user</param>
        /// <param name="userlist">List of users</param>
        /// <returns>user if found in userlist, otherwise returns null</returns>
        public User GetCurrentUser(string username, List<User> userlist)
        {
            try
            {
                for (int i = 0; i < userlist.Count; i++)
                {
                    if (userlist[i].Username.Equals(username))
                    {
                        string password = userlist[i].Password;
                        User user = new User(username, password);
                        return user;
                    }

                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;

        }

    }

    
}
