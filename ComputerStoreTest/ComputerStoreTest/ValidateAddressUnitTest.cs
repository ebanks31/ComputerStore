using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerStore;

namespace ComputerStoreTest
{

    /// <summary>
    /// This class makes tests valid and invalid addresses for customer registration. 
    /// </summary>
    [TestClass]
    public class ValidateAddressUnitTest
    {
        [TestMethod]
        public void Test_ValidAddress()
        {
            Register register = new Register();
            string validaddress = "2023 john creek dr.";
            register.ValidateAddress(validaddress);
            Assert.AreEqual(false, register.NotValidAddress);
        }

        [TestMethod]
        public void Test_ValidPOBox()
        {
            Register register = new Register();
            string validaddress = "P.O. Box 562";
            register.ValidateAddress(validaddress);
            Assert.AreEqual(false, register.NotValidAddress);
        }

        [TestMethod]
        public void Test_InvalidAddressWithEmail()
        {
            Register register = new Register();
            string validaddress = "test@gmail.com";
            register.ValidateAddress(validaddress);
            Assert.AreEqual(true, register.NotValidAddress);
        }

        [TestMethod]
        public void Test_InvalidAddressWithEmptyString()
        {
            Register register = new Register();
            string validaddress = "";
            register.ValidateAddress(validaddress);
            Assert.AreEqual(true, register.NotValidAddress);
        }

        [TestMethod]
        public void Test_InvalidAddressWithSpaces()
        {
            Register register = new Register();
            string validaddress = " ";
            register.ValidateAddress(validaddress);
            Assert.AreEqual(true, register.NotValidAddress);
        }
    }
}
