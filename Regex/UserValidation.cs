using System.Text.RegularExpressions;

namespace RegexClass;

public class UserValidation
{
    public void FirstNameValidation()
    {
        string FirstNamePattern = @"^[A-Z][a-z]{2,}$";
        Regex regexObject = new Regex(FirstNamePattern);
        Console.WriteLine("Plz enter first name for validation");
        string userInput = Console.ReadLine();
        if (regexObject.IsMatch(userInput))
            Console.WriteLine("Entered first name is valid");
        else
            Console.WriteLine("You entered invalid first name");
    }

    public void LastNameValidation()
    {
        string LastNamePattern = @"^[A-Z][a-z]{2,}$";
        Regex regexObject = new Regex(LastNamePattern);
        Console.WriteLine("Plz enter last name for validation");
        string userInput = Console.ReadLine();
        if (regexObject.IsMatch(userInput))
            Console.WriteLine("Entered last name is valid");
        else
            Console.WriteLine("You entered invalid last name");
    }
}