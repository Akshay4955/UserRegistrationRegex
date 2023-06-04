using System.Text.RegularExpressions;

namespace RegexClass;

public class UserValidation
{
    public void FirstNameValidation()
    {
        string FirstNamePattern = @"^[A-Z][a-z]{2,}$";
        Regex regexObject = new Regex(FirstNamePattern);
        string userInput = Console.ReadLine();
        if (regexObject.IsMatch(userInput))
            Console.WriteLine("Entered user name is valid");
        else
            Console.WriteLine("You entered invalid user name");
    }
}