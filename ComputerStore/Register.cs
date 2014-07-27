using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
namespace ComputerStore
{
    /// <summary>
    /// This class contains helper method for registering a new customer
    /// </summary>
    public class Register
    {

        private bool validPhonenumber;
        private bool validEmail;
        private bool validFirstName;
        private bool validLastName;
        private bool validAddress;
        private bool validCustomer;

        /// <summary>
        /// Default Constructor of RegisterClass
        /// </summary>
        public Register()
        {


        }

        /// <summary>
        /// Property of Phone number
        /// </summary>
        public bool NotValidPhonenumber
        {
            get { return validPhonenumber; }
            set { validPhonenumber = value; }
        }

        /// <summary>
        /// Property of First Address or PO Box
        /// </summary>
        public bool NotValidAddress
        {
            get { return validAddress; }
            set { validAddress = value; }
        }

        /// <summary>
        /// Property of Email
        /// </summary>
        public bool NotValidEmail
        {
            get { return validEmail; }
            set { validEmail = value; }
        }


        /// <summary>
        /// Property of First name
        /// </summary>
        public bool NotValidFirstName
        {
            get { return validFirstName; }
            set { validFirstName = value; }
        }

        /// <summary>
        /// Property of Last name
        /// </summary>
        public bool NotValidLastName
        {
            get { return validLastName; }
            set { validLastName = value; }
        }

        /// <summary>
        /// Property for displaying a  Valid Customer
        /// </summary>
        public bool ValidCustomer
        {
            get { return validCustomer; }
            set { validCustomer = value; }
        }

        /// <summary>
        /// Validate if an phone number is valid
        /// </summary>
        /// <param name="phonenumber">Phone number of customer</param>
        public void ValidatePhonenumber(string phonenumber)
        {
            string regExPattern = "^[2-9]\\d{2}-?\\d{3}-?\\d{4}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(phonenumber, regExPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                NotValidPhonenumber = true;

            }

        }

        /// <summary>
        /// Validate if an email address is valid
        /// </summary>
        /// <param name="email">Emaill of a customer</param>
        public void ValidateEmail(string email)
        {
            string regExPattern = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, regExPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                NotValidEmail = true;

            }

        }

        /// <summary>
        ///  Validate if the first name or last name is valid
        /// </summary>
        /// <param name="firstname">first name of a user</param>
        /// <param name="lastname">last name of a user</param>
        public void ValidateFirstNameAndLastName(string firstname, string lastname)
        {
            string regExPattern = "^[\\w]{1,20}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(firstname, regExPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                NotValidFirstName = true;
            }
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(lastname, regExPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                NotValidLastName = true;

            }
        }


        /// <summary>
        /// Validate if an address or PO Box is valid
        /// </summary>
        /// <param name="address">Address or PO Box</param>
        public void ValidateAddress(string address)
        {
            string addressregExPattern = "^[a-zA-Z0-9]+[\\s]*[a-zA-Z0-9.\\-\\,\\#]+[\\s]*[a-zA-Z0-9.\\-\\,\\#]+[a-zA-Z0-9\\s.\\-\\,\\#]*$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(address, addressregExPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                NotValidAddress = true;

            }

        }


        /// <summary>
        /// Validate if an PO Box is valid
        /// </summary>
        /// <param name="address">PO Box</param>
        public void ValidPOBox(string address)
        {

            string POBoxregExPattern = "\\b[P|p]?(OST|ost)?\\.?\\s*[O|o|0]?(ffice|FFICE)?\\.?\\s*[B|b][O|o|0]?[X|x]?\\.?\\s+[#]?(\\d+)\\b";
            if (!System.Text.RegularExpressions.Regex.IsMatch(address, POBoxregExPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase) && NotValidAddress == true)
            {
                NotValidAddress = true;
            }
            else
            {
                NotValidAddress = false;
            }
        }

        /// <summary>
        /// This methods validate the fields for registration
        /// </summary>
        /// <param name="firstname">Firstname of customer</param>
        /// <param name="lastname">Lastname of customer</param>
        /// <param name="address">Address of customer</param>
        /// <param name="phonenumber">Phone number of customer</param>
        /// <param name="email">Email of customer</param>
        public void ValidateRegisterFields(string firstname,string lastname,string address,string phonenumber,string email)
        {
            ValidateFirstNameAndLastName(firstname, lastname);
            ValidateAddress(address);
            ValidPOBox(address);
            ValidatePhonenumber(phonenumber);
            ValidateEmail(email);
        }

        /// <summary>
        /// Validate all the registration fields
        /// </summary>
        /// <param name="label">label from register form class</param>
        /// <returns>label that is updated for invalid fields</returns>
        public string ValidAllRegisterFields(string label,UserLogin userlogin)
        {
            if (NotValidFirstName)
            {
                label = "First name is invalid. Please enter a valid first name";
                return label;
            }
            else if (NotValidLastName)
            {
                label = "Last name is invalid. Please enter a valid last name";
                return label;
            }
            else if (NotValidAddress)
            {
                label = "Address is invalid. Please enter a valid address or PO Box";
                return label;
            }
            else if (NotValidPhonenumber)
            {
                label = "Phone number is invalid. Please enter a phone number";
                return label;
            }
            else if (NotValidEmail)
            {
                label = "Email is invalid. Please enter a email";
                return label;
            }
            else if (!userlogin.UsernameValid)
            {
                label = "Username is invalid. Please enter a username";
                return label;
            }
            else if(!userlogin.PasswordValid)
            {
                label = "Password is invalid. Please enter a password";
                return label;
            }
            else
            {
                label = "";
                ValidCustomer = true;
                return label;
            }
        }
    }
}




