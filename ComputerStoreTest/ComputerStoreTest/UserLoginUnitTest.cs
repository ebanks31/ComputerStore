using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerStore;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace ComputerStoreTest
{
    /// <summary>
    /// This class makes tests various functionalities for the User Login class.
    /// </summary>
    [TestClass]
    public class UserLoginUnitTest
    {
	
        [TestMethod]
        public void Test_DeserializeLogin()
        {
            UserLogin userLogin = new UserLogin();
            List<User> userlist = userLogin.DeserializeLogin();
		int userlistsize= userlist.Count;
        Assert.IsTrue(userlistsize > 0, "User list was not greater than zero");
        }

        [TestMethod]
        public void Test_DisplayInvalidUsernamePasswordColor()
        {
            UserLogin userLogin = new UserLogin();
		Label ErrorLabel = new Label();
        userLogin.DisplayInvalidUsernamePasswordMessage(ErrorLabel); ;
         Assert.AreEqual(Color.Red, ErrorLabel.ForeColor);
        }

		[TestMethod]
        public void Test_DisplayInvalidUsernamePasswordUserMessage()
        {
            UserLogin userLogin = new UserLogin();
		Label ErrorLabel = new Label();
        userLogin.DisplayInvalidUsernamePasswordMessage(ErrorLabel);
		string usernamePasswordMessage = "Username/Password is invalid. \nPlease enter only alphabets or numbers. Username should be at most 15 chars";
        Assert.AreEqual(userLogin.usernamePasswordMessage, usernamePasswordMessage);
        }
		
        [TestMethod]
        public void Test_SerializeLogin()
        {
		UserLogin userLogin = new UserLogin();
		User user = new User("test3","test3");
        userLogin.SerializeLogin(user);
        List<User> userlist = userLogin.DeserializeLogin();
		
		int userlistsize= userlist.Count;
        bool validuser = userLogin.CheckValidUser(user, userlist);
        Assert.IsTrue(validuser, "User is valid");
        }

        
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),
    "Userlist of null was inappropriately allowed.")]
        public void Test_SerializeLoginEmptyUserlist()
        {
            UserLogin userLogin = new UserLogin();
		User user = new User("test4","test4");
        userLogin.SerializeLogin(user);
		List<User> userlist = null;
		
		int userlistsize= userlist.Count;
        bool validuser = userLogin.CheckValidUser(user, userlist);
        Assert.IsFalse(validuser, "User is valid");
        }
		
		[TestMethod]
        [ExpectedException(typeof(NullReferenceException),
"Userlist of null was inappropriately allowed.")]
        public void Test_SerializeLoginEmptyUser()
        {
            UserLogin userLogin = new UserLogin();
		User user = new User();
        userLogin.SerializeLogin(user);
		List<User> userlist = null;
		
		int userlistsize= userlist.Count;
        bool validuser = userLogin.CheckValidUser(user, userlist);
        Assert.IsFalse(validuser, "User is valid");
        }

		[TestMethod]
        public void Test_SerializeLoginUserList()
        {
            UserLogin userLogin = new UserLogin();
		User user1 = new User("test6","test6");
		User user2 = new User("test7","test7");
		List<User> userlist = new List<User>();
		userlist.Add(user1);
		userlist.Add(user2);

        userLogin.SerializeLogin(userlist);
        List<User> deserializeuserlist = userLogin.DeserializeLogin();
		int userlistsize= deserializeuserlist.Count;

        bool validuser = userLogin.CheckValidUser(user1, deserializeuserlist);
        bool validuser2 = userLogin.CheckValidUser(user2, deserializeuserlist);
        Assert.IsTrue(validuser, "User is valid");
		Assert.IsTrue(validuser2, "User is valid");
        }
		
		//Username Checks
		[TestMethod]
        public void Test_ValidUsernameandPassword()
        {
		UserLogin userLogin = new UserLogin();
		string username = "Eric";
		string password ="Banks";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
		Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_InvalidUsernameWithOneCharacterandValidPassword()
        {
		UserLogin userLogin = new UserLogin();
		string username = "E";
		string password ="Banks";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsFalse(userLogin.UsernameValid, "User is valid");
		Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }

		[TestMethod]
        public void Test_InvalidUsernameWithTwoCharacterandValidPassword()
        {
		UserLogin userLogin = new UserLogin();
		string username = "Er";
		string password ="Banks";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsFalse(userLogin.UsernameValid, "User is valid");
		Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_ValidUsernameWithThreeCharacterandValidPassword()
        {
            UserLogin userLogin = new UserLogin();
		string username = "Eri";
		string password ="Banks";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
		Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_ValidUsernameWithFourCharacterandValidPassword()
        {
		UserLogin userLogin = new UserLogin();
		string username = "Eric";
		string password ="Banks";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
		Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_ValidUsernameWithFourteenCharacterandValidPassword()
        {
            UserLogin userLogin = new UserLogin();
		string username = "Ericbasfdsfdsa";
		string password ="Banks";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
        Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_ValidUsernameWithFifteenCharacterandValidPassword()
        {
		UserLogin userLogin = new UserLogin();
		string username = "Ericbasfdsfdsaa";
		string password ="Banks";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
		Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_InvalidUsernameWithSixteenCharacterandValidPassword()
        {
            UserLogin userLogin = new UserLogin();
		string username = "Ericbasfdsfdsaaf";
		string password ="Banks";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsFalse(userLogin.UsernameValid, "User is valid");
        Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_ValidUsernameWithAlphanumericsandValidPassword()
        {
		UserLogin userLogin = new UserLogin();
		string username = "Eric1234";
		string password ="Banks";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsFalse(userLogin.UsernameValid, "User is valid");
		Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_InvalidUsernameWithEmptyStringandPassword()
        {
		UserLogin userLogin = new UserLogin();
		string username = "";
		string password ="Banks";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsFalse(userLogin.UsernameValid, "User is valid");
		Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_InvalidUsernameWithSpaceandPassword()
        {
		UserLogin userLogin = new UserLogin();
		string username = " ";
		string password ="Banks";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsFalse(userLogin.UsernameValid, "User is valid");
		Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		//Password Checks
        [TestMethod]
        public void Test_ValidUsernameandInvalidPasswordWithOneCharacter()
        {
		UserLogin userLogin = new UserLogin();
		string username = "Eric";
		string password ="E";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
		Assert.IsFalse(userLogin.PasswordValid, "Password is valid");
        }

		[TestMethod]
        public void Test_InvalidUsernameWithTwoCharacterandInvalidPasswordWithTwoCharacter()
        {
		UserLogin userLogin = new UserLogin();
		string username = "Eric";
		string password ="Er";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
		Assert.IsFalse(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_ValidUsernameandValidPasswordWithThreeCharacter()
        {
		UserLogin userLogin = new UserLogin();
		string username = "Eric";
		string password ="Eri";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
		Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_ValidUsernameandValidPasswordWithFourCharacter()
        {
		UserLogin userLogin = new UserLogin();
		string username = "Ericba";
		string password ="Eric";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
		Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_ValidUsernameandValidPasswordWithFourteenCharacter()
        {
            UserLogin userLogin = new UserLogin();
		string username = "Eric";
		string password ="Ericbasfdsfdsa";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
        Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_ValidUsernameandValidPasswordWithFifteenCharacter()
        {
		UserLogin userLogin = new UserLogin();
		string username = "Eric";
		string password ="Ericbasfdsfdsaa";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
		Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_ValidUsernameandInvalidPasswordWithSixteenCharacter()
        {
            UserLogin userLogin = new UserLogin();
		string username = "Eric";
		string password ="Ericbasfdsfdsaaf";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
        Assert.IsFalse(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_ValidUsernameandValidPasswordWithAlphanumerics()
        {
		UserLogin userLogin = new UserLogin();
		string username = "Eric";
		string password ="Eric1234";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
		Assert.IsTrue(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_ValidUsernameandInvalidPasswordWithEmptyString()
        {
		UserLogin userLogin = new UserLogin();
		string username = "Eric";
		string password ="";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
		Assert.IsFalse(userLogin.PasswordValid, "Password is valid");
        }
		
		[TestMethod]
        public void Test_ValidUsernameandInvalidPasswordWithSpace()
        {
		UserLogin userLogin = new UserLogin();
		string username = "Eric";
		string password =" ";
        bool validuser = userLogin.UsernamePasswordValidation(username,password);
        Assert.IsTrue(userLogin.UsernameValid, "User is valid");
		Assert.IsFalse(userLogin.PasswordValid, "Password is valid");
        }
    }
}
