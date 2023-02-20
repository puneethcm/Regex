using UserInputValidation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to User Input Validation");
        UserValidation validate = new UserValidation();
        Console.WriteLine("\nChoose the options to validate");
        Console.WriteLine("1:First Name\n2:Last Name\n3:Email\n4:Phone Number\n5:PassWord");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();
                validate.ValidateFirstName(firstName);
                break;
            case 2:
                Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();
                validate.ValidatLastName(lastName);
                break;
            case 3:
                Console.WriteLine("Enter Email Name");
                string email = Console.ReadLine();
                validate.ValidateEmailName(email);
                break;
            case 4:
                Console.WriteLine("Enter Phone Number");
                string phoneNumber = Console.ReadLine();
                validate.ValidatePhoneNumber(phoneNumber);
                break;
            case 5:
                Console.WriteLine("Enter Pass Word");
                string passWord = Console.ReadLine();
                validate.ValidatePassWord(passWord);
                break;

        }
        Console.ReadLine();
    }
}