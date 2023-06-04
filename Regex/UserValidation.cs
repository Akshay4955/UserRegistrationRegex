using System.Text.RegularExpressions;

namespace RegexClass;

public class UserValidation
{
    public void FirstNameValidation()
    {
        string firstNamePattern = @"^[A-Z][a-z]{2,}$";
        Regex regexObject = new Regex(firstNamePattern);
        Console.WriteLine("Plz enter first name for validation");
        string userInput = Console.ReadLine();
        if (regexObject.IsMatch(userInput))
            Console.WriteLine("Entered first name is valid");
        else
            Console.WriteLine("You entered invalid first name");
    }

    public void LastNameValidation()
    {
        string lastNamePattern = @"^[A-Z][a-z]{2,}$";
        Regex regexObject = new Regex(lastNamePattern);
        Console.WriteLine("Plz enter last name for validation");
        string userInput = Console.ReadLine();
        if (regexObject.IsMatch(userInput))
            Console.WriteLine("Entered last name is valid");
        else
            Console.WriteLine("You entered invalid last name");
    }

    
    public void EmailValidation()
    {
        string emailPattern = @"^[a-z]+([+_.-]?[a-zA-Z0-9])*[@][a-zA-Z0-9]+([.][a-z]{2,3}){1,2}$";
        Regex regexObject = new Regex(emailPattern);
        Console.WriteLine("Plz enter email for validation");
        string userInput = Console.ReadLine();
        if (regexObject.IsMatch(userInput))
            Console.WriteLine("Entered email is valid");
        else
            Console.WriteLine("You entered invalid email");
    }

    public void MobileValidation()
    {
        string mobilePattern = @"^(91)[\s][0-9]{10}$";
        Regex regexObject = new Regex(mobilePattern);
        Console.WriteLine("Plz enter mobile number for validation");
        string userInput = Console.ReadLine();
        if (regexObject.IsMatch(userInput))
            Console.WriteLine("Entered mobile number is valid");
        else
            Console.WriteLine("You entered invalid mobile number");
    }

    public void PasswordValidation()
    {
        string passwordPattern = @"^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9~!@#$& *-]{8,}$";
        Regex regexObject = new Regex(passwordPattern);
        Console.WriteLine("Plz enter password for validation");
        string userInput = Console.ReadLine();
        if (regexObject.IsMatch(userInput))
            Console.WriteLine("Entered password is valid");
        else
            Console.WriteLine("You entered invalid password");
    }
}
