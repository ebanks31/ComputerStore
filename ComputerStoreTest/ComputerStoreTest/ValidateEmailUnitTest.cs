using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerStore;

namespace ComputerStoreTest
{

    /// <summary>
    /// This class makes tests valid and invalid email for customer registration. 
    /// </summary>
    /// </summary>
    [TestClass]
    public class ValidateEmailUnitTest
    {
        [TestMethod]
        public void Test_ValidEmailWithDashes()
    {
	Register register = new Register();
    string validemail = "test@gmail.com";
    register.ValidateEmail(validemail);
    Assert.AreEqual(false, register.NotValidEmail);
    }

        [TestMethod]
        public void Test_ValidEmailWithTwoCharacters()
{
	Register register = new Register();
	string validemail = "t2@gmail.com";
	register.ValidateEmail(validemail);
    Assert.AreEqual(false, register.NotValidEmail);
}

        [TestMethod]
        public void Test_ValidEmailWithOneCharacter()
{
	Register register = new Register();
	string validemail = "t@gmail.com";
    register.ValidateEmail(validemail);
    Assert.AreEqual(false, register.NotValidEmail);
}

        [TestMethod]
        public void Test_ValidEmailWithYahoo()
{
	Register register = new Register();
    string validemail = "test@yahoo.com";
	register.ValidateEmail(validemail);
    Assert.AreEqual(false, register.NotValidEmail);
}

        [TestMethod]
        public void Test_ValidEmailWithHotmail()
{
	Register register = new Register();
    string validemail = "test@hotmail.com";
	register.ValidateEmail(validemail);
    Assert.AreEqual(false, register.NotValidEmail);
}

        [TestMethod]
        public void Test_InvalidEmailWithoutAtSign()
{
	Register register = new Register();
    string validemail = "testhotmail.com";
	register.ValidateEmail(validemail);
    Assert.AreEqual(true, register.NotValidEmail);
}

        [TestMethod]
        public void Test_InvalidEmailWithoutAtSign2()
{
	Register register = new Register();
    string validemail = "hotmail.com";
	register.ValidateEmail(validemail);
    Assert.AreEqual(true, register.NotValidEmail);
}

        [TestMethod]
        public void Test_validEmailWithAllNumbers()
{
	Register register = new Register();
	string validemail = "12131@hotmail.com";
    register.ValidateEmail(validemail);
    Assert.AreEqual(false, register.NotValidEmail);
}

        [TestMethod]
        public void Test_InvalidEmailWithNoCharactersBeforeAddress()
        {
            Register register = new Register();
            string validemail = "@hotmail.com";
            register.ValidateEmail(validemail);
            Assert.AreEqual(true, register.NotValidEmail);
        }
		
		        [TestMethod]
        public void Test_InvalidEmailWithEmptyString()
        {
            Register register = new Register();
            string validemail = "";
            register.ValidateEmail(validemail);
            Assert.AreEqual(true, register.NotValidEmail);
        }
		
				        [TestMethod]
        public void Test_InvalidEmailWithSpace()
        {
            Register register = new Register();
            string validemail = " ";
            register.ValidateEmail(validemail);
            Assert.AreEqual(true, register.NotValidEmail);
        }
    }
	
}
