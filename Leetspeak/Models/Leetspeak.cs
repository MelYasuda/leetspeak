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
        char[] array = userInput.ToCharArray();

        foreach (char item in array) {
          Console.WriteLine(item);
        }

        return userInput;
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
