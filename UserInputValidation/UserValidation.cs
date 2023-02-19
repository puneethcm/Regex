using System;
using System.Text.RegularExpressions;

namespace UserInputValidation
{
	public class UserValidation
	{
		public const string First_Name = "^[A-Z]{1}[a-zA-Z]{3,}$";
        public const string Last_Name = "^[A-Z]{1}[a-zA-Z]{3,}$";
        public const string EMAIL = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";



        public void ValidateFirstName(string firstName)
		{
			Regex regex = new Regex(First_Name);
			bool result = regex.IsMatch(firstName);

            if (result == true)
            {
                Console.WriteLine("The Enter First Name is Valid");
            }
            else
            {
                Console.WriteLine("The Enter First Name is Not Valid");
                Console.WriteLine("The First letter shoud be capital");
            }
        }
        public void ValidatLastName(string lastName)
        {
            Regex regex = new Regex(Last_Name);
            bool result = regex.IsMatch(lastName);

            if (result == true)
            {
                Console.WriteLine("The Enter Last Name is Valid");
            }
            else
            {
                Console.WriteLine("The Enter Last Name is Not Valid");
                Console.WriteLine("The First letter shoud be capital");
            }
        }
        public void ValidateEmailName(string email)
        {
            Regex regex = new Regex(EMAIL);
            bool result = regex.IsMatch(email);

            Console.WriteLine(result);
        }
    }
}

