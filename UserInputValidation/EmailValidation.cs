using System;
using System.Text.RegularExpressions;

namespace UserInputValidation
{
	public class EmailValidation
	{
		public const string Email_Validation= "^[a-zA-Z0-9]+[.+-_]{0,1}[a-zA-Z0-9]+[@][a-zA-Z0-9]+([.][a-zA-Z]{1,})+([.][a-zA-Z]{1,}){0,1}$";

        public void ValidateEmail(string email)
        {
            Regex regex = new Regex(Email_Validation);
            bool result = regex.IsMatch(email);

            if (result == true)
            {
                Console.WriteLine("The Enter Email is Valid");
            }
            else
            {
                Console.WriteLine("The Enter Email is Not Valid");
                Console.WriteLine("The First letter shoud be capital");
            }
        }
    }
}

