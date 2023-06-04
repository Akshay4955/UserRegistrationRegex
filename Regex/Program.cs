namespace RegexClass;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Regex...!!!");

        UserValidation userValidation = new UserValidation();
        userValidation.FirstNameValidation();
        userValidation.LastNameValidation();
        userValidation.EmailValidation();
        userValidation.MobileValidation();

    }
}
