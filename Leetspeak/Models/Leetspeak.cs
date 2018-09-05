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
          if (originalArray[i] == 'e')
          {
            translatedArray[i] = '3';
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
      LeetspeakTranslator translator = new LeetspeakTranslator();
      translator.Translate("something");
    }
  }
}
