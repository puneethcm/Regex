using UserInputValidation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to User Input Validation");
        Console.WriteLine("Enter First Name");
        string firstName = Console.ReadLine();
        UserValidation validate = new UserValidation(firstName);
        validate.ValidateFirstName();
        Console.ReadLine();
    }
}