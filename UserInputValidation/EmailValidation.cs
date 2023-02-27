using System;
using System.Text.RegularExpressions;

namespace UserInputValidation
{
	public class EmailValidation
	{
		public const string Email_Validation= @"^([a-z0-9\.\-\+]+)?@([a-z0-9]+)\.([a-z\,\.]+)$";

        public string ValidateEmail(string email)
        {
            Regex regex = new Regex(Email_Validation);
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
    }
}

