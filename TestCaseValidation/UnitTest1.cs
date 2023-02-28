using UserInputValidation;

namespace TestCaseValidation;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [TestCategory("First Name")]
    [DataRow("Puneeth", "Valid")]
    [DataRow("puneeth", "Invalid")]
    public void TestFirstName(string input, string expected)
    {
        string pattren = "^[A-Z]{1}[a-zA-Z]{3,}$";

    UserValidation validate = new UserValidation();

        string actual = validate.ValidateFirstName(input);

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [TestCategory("Last Name")]
    [DataRow("Kumar", "Valid")]
    [DataRow("kumar", "Invalid")]
    public void TestLastName(string input, string expected)
    {
        string pattren = "^[A-Z]{1}[a-zA-Z]{3,}$";

        UserValidation validate = new UserValidation();

        string actual = validate.ValidatLastName(input);

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [TestCategory("Email")]
    [DataRow("abc.xyz@bl.co.in", "Valid")]
    [DataRow("abc.xyz@bl.in", "Invalid")]
    public void TestEmailId(string input, string expected)
    {
        string pattren = "^([a-zA-Z]+)([.][a-z0-9]+)?@([bl]+)([.][co]+)([.][a-z]{2,})?$";

        UserValidation validate = new UserValidation();

        string actual = validate.ValidateEmailName(input);

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [TestCategory("Phone Number")]
    [DataRow("91 9900990000", "Valid")]
    [DataRow("9945673673", "Invalid")]
    public void TestPhoneNumber(string input, string expected)
    {
        string pattren = "^[0-9]{2}[ ]?[0-9]{10}$";

        UserValidation validate = new UserValidation();

        string actual = validate.ValidatePhoneNumber(input);

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [TestCategory("PassWord")]
    [DataRow("puneKumacm123$", "Valid")]
    [DataRow("Puneeth123", "Invalid")]
    public void TestPassWord(string input, string expected)
    {
        string pattren = "^[a-zA-Z]*[0-9]{1,}[#?!@$%^&*-]{1,}$";

        UserValidation validate = new UserValidation();

        string actual = validate.ValidatePassWord(input);

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [TestCategory("Validate Given Emails")]
    [DataRow("abc@yahoo.com,", "Valid")]
    [DataRow("abc-100@yahoo.com,", "Valid")]
    [DataRow("abc.100@yahoo.com", "Valid")]
    [DataRow("abc111@abc.com,", "Valid")]
    [DataRow("abc-100@abc.net,", "Valid")]
    [DataRow("abc.100@abc.com.au", "Valid")]
    [DataRow("abc@1.com,", "Valid")]
    [DataRow("abc@gmail.com.com", "Valid")]
    [DataRow("abc+100@gmail.com", "Valid")]
    public void ValidateEmail(string input, string expected)
    {
        
        EmailValidation validate = new EmailValidation();

        string actual = validate.ValidateEmail(input);

        Assert.AreEqual(expected, actual);    
    }
}
