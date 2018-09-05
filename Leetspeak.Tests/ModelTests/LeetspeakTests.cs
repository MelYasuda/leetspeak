using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;
using System.Collections.Generic;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTests
  {
    [TestMethod]
    public void Translate_ValidUserInput()
    {
      LeetspeakTranslator translator = new LeetspeakTranslator();
      Assert.AreEqual("Invalid input", translator.Translate(""));
    }
    // [TestMethod]
    // public void Translate_SplitUserInput()
    // {
    //   LeetspeakTranslator translator = new LeetspeakTranslator();
    //   Assert.AreEqual("Invalid input", translator.Translate(""));
    //   Assert.AreEqual("something", translator.Translate("something"));
    // }
  }
}
