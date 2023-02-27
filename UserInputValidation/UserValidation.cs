using System;
using System.Text.RegularExpressions;

namespace UserInputValidation
{
	public class UserValidation
	{
        public const string First_Name = "^[A-Z]{1}[a-zA-Z]{3,}$";
        public const string Last_Name = "^[A-Z]{1}[a-zA-Z]{3,}$";
        public const string EMAIL = "^([a-zA-Z]+)([.][a-z0-9]+)?@([bl]+)([.][co]+)([.][a-z]{2,})?$";
        public const string Phone_Number = "^[0-9]{2}[ ]?[0-9]{10}$";
        public const string Pass_Word = "^[a-zA-Z]*[0-9]{1,}[#?!@$%^&*-]{1,}$";


        public string ValidateFirstName(string firstName)
        {
            Regex regex = new Regex(First_Name);
            bool result = regex.IsMatch(firstName);

            if (result == true)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        public string ValidatLastName(string lastName)
        {
            Regex regex = new Regex(Last_Name);
            bool result = regex.IsMatch(lastName);

            if (result == true)
            {
                return "Valid";
            }
            else
            {
                return "InVvlid";
            }
        }
        public string ValidateEmailName(string email)
        {
            Regex regex = new Regex(EMAIL);
            bool result = regex.IsMatch(email);

            if (result == true)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        public string ValidatePhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(Phone_Number);
            bool result = regex.IsMatch(phoneNumber);

            if (result == true)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        public string ValidatePassWord(string passWord)
        {
            Regex regex = new Regex(Pass_Word);
            bool result = regex.IsMatch(passWord);

            if (result == true)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }

    }
}

