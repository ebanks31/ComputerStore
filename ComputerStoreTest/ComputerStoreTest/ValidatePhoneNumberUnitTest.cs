using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerStore;

namespace ComputerStoreTest
{
    /// <summary>
    /// This class makes tests valid and invalid phonenumbers for customer registration. 
    /// </summary>
    [TestClass]
    public class ValidatePhoneNumberUnitTest
    {
        // unit test code
        [TestMethod]
        public void Test_ValidPhonenumberWithDashes()
{
	Register register = new Register();
	string validphonenumber = "234-456-6789";
    register.ValidatePhonenumber(validphonenumber);
    Assert.AreEqual(false, register.NotValidPhonenumber);
}
        
        // unit test code
        [TestMethod]
        public void Test_ValidPhonenumberWithoutDashes()
{
	Register register = new Register();
	string validphonenumber = "2344566789";
    register.ValidatePhonenumber(validphonenumber);
    Assert.AreEqual(false, register.NotValidPhonenumber);
}

        // unit test code
        [TestMethod]
        public void Test_ValidPhonenumberWithandWithoutDashes()
{
	Register register = new Register();
	string validphonenumber = "123-4566789";
    register.ValidatePhonenumber(validphonenumber);
    Assert.AreEqual(true, register.NotValidPhonenumber);
}

        // unit test code
        [TestMethod]
        public void Test_InvalidPhonenumberWithDashesInWrongPosition()
{
	Register register = new Register();
	string validphonenumber = "12-3456-6789";
    register.ValidatePhonenumber(validphonenumber);
    Assert.AreEqual(true, register.NotValidPhonenumber);
}

        // unit test code
        [TestMethod]
        public void Test_InvalidPhonenumberWithDashesInWrongPosition2()
{
	Register register = new Register();
    string validphonenumber = "123456678-9";
	register.ValidatePhonenumber(validphonenumber);
    Assert.AreEqual(true, register.NotValidPhonenumber);
}

        // unit test code
        [TestMethod]
        public void Test_InvalidPhonenumberWithDashesInWrongPosition3()
{
	Register register = new Register();
    string validphonenumber = "12345667-89";
	register.ValidatePhonenumber(validphonenumber);
    Assert.AreEqual(true, register.NotValidPhonenumber);
}

        // unit test code
        [TestMethod]
        public void Test_InvalidPhonenumberWithEmptyString()
{
	Register register = new Register();
    string validphonenumber = "";
	register.ValidatePhonenumber(validphonenumber);
    Assert.AreEqual(true, register.NotValidPhonenumber);
}

        // unit test code
        [TestMethod]
        public void Test_InvalidPhonenumberWithSpaceString()
{
	Register register = new Register();
    string validphonenumber = " ";
	register.ValidatePhonenumber(validphonenumber);
    Assert.AreEqual(true, register.NotValidPhonenumber);
}

        // unit test code
        [TestMethod]
        public void Test_InvalidPhonenumberWithAlphabet()
{
	Register register = new Register();
    string validphonenumber = "ABC-DEF-GHIJ";
	register.ValidatePhonenumber(validphonenumber);
    Assert.AreEqual(true, register.NotValidPhonenumber);
}

        // unit test code
        [TestMethod]
        public void Test_InvalidPhonenumberWithAlphanumerics()
{
	Register register = new Register();
    string validphonenumber = "123-DEF-4567";
	register.ValidatePhonenumber(validphonenumber);
    Assert.AreEqual(true, register.NotValidPhonenumber);
}

        // unit test code
        [TestMethod]
        public void Test_InvalidPhonenumberWithNotTwoParts()
{
	Register register = new Register();
    string validphonenumber = "456-4567";
	register.ValidatePhonenumber(validphonenumber);
    Assert.AreEqual(true, register.NotValidPhonenumber);
}

        [TestMethod]
        public void Test_InvalidPhonenumberEightDigitsNoDashes()
{
	Register register = new Register();
    string validphonenumber = "94564567";
	register.ValidatePhonenumber(validphonenumber);
    Assert.AreEqual(true, register.NotValidPhonenumber);
}
    
	
	        [TestMethod]
        public void Test_InvalidPhonenumberOneDigitsNoDashes()
{
	Register register = new Register();
    string validphonenumber = "9";
	register.ValidatePhonenumber(validphonenumber);
    Assert.AreEqual(true, register.NotValidPhonenumber);
}
    }
}
