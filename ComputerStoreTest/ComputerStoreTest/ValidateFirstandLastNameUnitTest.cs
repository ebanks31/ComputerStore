using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerStore;

namespace ComputerStoreTest
{

    /// <summary>
    /// This class makes tests valid and invalid First and Lastnames for customer registration. 
    /// </summary>
    [TestClass]
    public class ValidateFirstandLastNameUnitTest
    {
[TestMethod]
public void Test_ValidFirstAndLastName()
{
	Register register = new Register();
	string firstname = "Eric";
	string lastname = "Banks";
    register.ValidateFirstNameAndLastName(firstname, lastname);
    Assert.AreEqual(false, register.NotValidFirstName);
    Assert.AreEqual(false, register.NotValidLastName);
}

[TestMethod]
public void Test_InvalidFirstAndValidLastName()
{
    Register register = new Register();
    string firstname = ".....";
    string lastname = "Banks";
    register.ValidateFirstNameAndLastName(firstname, lastname);
    Assert.AreEqual(true, register.NotValidFirstName);
    Assert.AreEqual(false, register.NotValidLastName);
}

[TestMethod]
public void Test_ValidFirstAndInvalidLastName()
{
    Register register = new Register();
    string firstname = "Eric";
    string lastname = "......";
    register.ValidateFirstNameAndLastName(firstname, lastname);
    Assert.AreEqual(false, register.NotValidFirstName);
    Assert.AreEqual(true, register.NotValidLastName);
}


[TestMethod]
public void Test_EmptyFirstAndInvalidLastName()
{
    Register register = new Register();
    string firstname = "";
    string lastname = "Banks";
    register.ValidateFirstNameAndLastName(firstname, lastname);
    Assert.AreEqual(true, register.NotValidFirstName);
    Assert.AreEqual(false, register.NotValidLastName);
}

[TestMethod]
public void Test_EmptyFirstAndEmptyLastName()
{
    Register register = new Register();
    string firstname = "";
    string lastname = "";
    register.ValidateFirstNameAndLastName(firstname, lastname);
    Assert.AreEqual(true, register.NotValidFirstName);
    Assert.AreEqual(true, register.NotValidLastName);
}

[TestMethod]
public void Test_ValidFirstAndEmptyLastName()
{
    Register register = new Register();
    string firstname = "Eric";
    string lastname = "";
    register.ValidateFirstNameAndLastName(firstname, lastname);
    Assert.AreEqual(false, register.NotValidFirstName);
    Assert.AreEqual(true, register.NotValidLastName);
}

[TestMethod]
public void Test_SpaceFirstAndInvalidLastName()
{
    Register register = new Register();
    string firstname = " ";
    string lastname = "Banks";
    register.ValidateFirstNameAndLastName(firstname, lastname);
    Assert.AreEqual(true, register.NotValidFirstName);
    Assert.AreEqual(false, register.NotValidLastName);
}

[TestMethod]
public void Test_ValidFirstAndSpaceLastName()
{
    Register register = new Register();
    string firstname = "Eric";
    string lastname = " ";
    register.ValidateFirstNameAndLastName(firstname, lastname);
    Assert.AreEqual(false, register.NotValidFirstName);
    Assert.AreEqual(true, register.NotValidLastName);
}

[TestMethod]
public void Test_ValidSpaceFirstAndSpaceLastName()
{
    Register register = new Register();
    string firstname = " ";
    string lastname = " ";
    register.ValidateFirstNameAndLastName(firstname, lastname);
    Assert.AreEqual(true, register.NotValidFirstName);
    Assert.AreEqual(true, register.NotValidLastName);
}
    }
}
