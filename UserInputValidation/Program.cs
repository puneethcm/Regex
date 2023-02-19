using UserInputValidation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to User Input Validation");
        UserValidation validate = new UserValidation();

        Console.WriteLine("Enter First Name");
        string firstName = Console.ReadLine();
        validate.ValidateFirstName(firstName);

        Console.WriteLine("Enter Last Name");
        string lastName = Console.ReadLine();
        validate.ValidatLastName(lastName);

        Console.WriteLine("Enter Email Name");
        string email = Console.ReadLine();
        validate.ValidateEmailName(email);

        Console.WriteLine("Enter Phone Number");
        string phoneNumber = Console.ReadLine();
        validate.ValidatePhoneNumber(phoneNumber);

        Console.ReadLine();
    }
}