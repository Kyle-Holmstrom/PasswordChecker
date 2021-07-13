using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "1234567890";
      string specialChars = "!@#$%^&*";
      int score = 0;

      Console.WriteLine("Enter a new password: ");
      string password = Console.ReadLine();
      
      int len = password.Length;
      
      if (len >= 8) 
      {
        score++;
      } 
      if (Tools.Contains(password, uppercase))
      {
        score++;
      } 
      if (Tools.Contains(password, lowercase))
      {
        score++;
      }
      if (Tools.Contains(password, digits))
      {
        score++;
      }
      if (Tools.Contains(password, specialChars))
      {
        score++;
      }

      switch (score)
      {
        case 5:
        case 4:
        Console.WriteLine("The password is EXTREMELY STRONG!");
        break;
        case 3:
        Console.WriteLine("The password is STRONG.");
        break;
        case 2:
        Console.WriteLine("The password is MEDIUM.");
        break;
        case 1:
        Console.WriteLine("The password is WEAK");
        break;
        default:
        Console.WriteLine("The password doesn't meet any of the standards.");
        break;
      }

    Console.WriteLine(score);
    }
  }
}
