using System;
using System.Collections.Generic;

namespace Leetspeak
{
  public class LeetspeakTranslator
  {
    public string Translate(string userInput)
    {
      // if input is "", return "Invalid input"
      if (userInput == "")
      {
        return "Invalid input";
      }
      else
      {
        char[] originalArray = userInput.ToCharArray();

        int userInputLength = originalArray.Length;
        char[] translatedArray = new char[userInputLength];

        // replace e with 3
        for (int i=0; i<originalArray.Length; i++)
        {
          if (originalArray[i] == 'e' || originalArray[i] == 'E')
          {
            translatedArray[i] = '3';
          }
          else if (originalArray[i] == 'o' || originalArray[i] == 'O')
          {
            translatedArray[i] = '0';
          }
          else if (originalArray[i] == 'I')
          {
            translatedArray[i] = '1';
          }
          else if (originalArray[i] == 't' || originalArray[i] == 'T')
          {
            translatedArray[i] = '7';
          }
          else if ((i != 0 && originalArray[i] == 's') || (i != 0 && originalArray[i] == 'S'))
          {
            translatedArray[i] = 'z';
          }
          else
          {
            translatedArray[i] = originalArray[i];
          }
        }

        string result = new string(translatedArray);

        return result;
      }
    }
  }
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a sentence.");
      string userInput = Console.ReadLine();
      LeetspeakTranslator translator = new LeetspeakTranslator();
      Console.WriteLine(translator.Translate(userInput));
    }
  }
}
