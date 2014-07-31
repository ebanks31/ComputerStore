using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerStore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerStoreTest
{
    [TestClass]
    public class UserUnitTest
    {
        [TestMethod]
        public void TestAddUser()
        {
            string username = "test";
            string password = "test2";
            User user = new User(username, password);
            UserLogin userlogin = new UserLogin();
            
            user.AddUser(user);
            List<User> currentuserlist= userlogin.DeserializeLogin();
            User currentuser = user.GetCurrentUser(user.Username, currentuserlist);
            Assert.AreEqual("test", currentuser.Username);
            Assert.AreEqual("test2", currentuser.Password);
        }

        [TestMethod]
        public void TestAddUserWithUsernameAndPasswordEmpty()
        {
            string username = "";
            string password = "";
            User user = new User(username, password);

            UserLogin userlogin = new UserLogin();

            user.AddUser(user);
            List<User> currentuserlist = userlogin.DeserializeLogin();
            User currentuser = user.GetCurrentUser(user.Username, currentuserlist);
            Assert.AreNotEqual("test", currentuser.Username);
            Assert.AreNotEqual("test2", currentuser.Password);
        }

		[TestMethod]
        public void TestAddUserWithUsernameAndPasswordSpaces()
        {
            string username = " ";
            string password = " ";
            User user = new User(username, password);

            UserLogin userlogin = new UserLogin();
            user.AddUser(user);
            List<User> currentuserlist = userlogin.DeserializeLogin();
            User currentuser = user.GetCurrentUser(user.Username, currentuserlist);
            Assert.AreNotEqual("test", currentuser.Username);
            Assert.AreNotEqual("test2", currentuser.Password);
        }
		
        [TestMethod]
        public void TestRemoveUser()
        {
            string username = "test";
            string password = "test";
            User user = new User(username, password);
            UserLogin userlogin = new UserLogin();

            user.AddUser(user);
            List<User> currentuserlist = userlogin.DeserializeLogin();
            List<User> finaluserlist = user.removeUser(user, currentuserlist);
            User.userlist = currentuserlist;
            User currentuser = user.GetCurrentUser(user.Username, finaluserlist);
            Assert.IsNull(currentuser);
        }
    }
}
