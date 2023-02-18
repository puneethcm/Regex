using System;
using System.Text.RegularExpressions;

namespace UserInputValidation
{
	public class UserValidation
	{
		public const string First_Name = "^[A-Z]{1}[a-zA-Z]{3,}$";
		public string first;

		public UserValidation(string firstName)
		{
			this.first = firstName;
		}

		public void ValidateFirstName()
		{
			Regex regex = new Regex(First_Name);
			bool result = regex.IsMatch(this.first);

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
    }
}

