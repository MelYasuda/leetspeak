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
    [TestMethod]
    public void Translate_ReplaceEWith3()
    {
      LeetspeakTranslator translator = new LeetspeakTranslator();
      Assert.AreEqual("3", translator.Translate("e"));
    }
    [TestMethod]
    public void Translate_ReplaceOWith0()
    {
      LeetspeakTranslator translator = new LeetspeakTranslator();
      Assert.AreEqual("0", translator.Translate("o"));
    }
    [TestMethod]
    public void Translate_ReplaceUpperIWith1()
    {
      LeetspeakTranslator translator = new LeetspeakTranslator();
      Assert.AreEqual("1", translator.Translate("I"));
    }
    [TestMethod]
    public void Translate_ReplaceUpperTWith7()
    {
      LeetspeakTranslator translator = new LeetspeakTranslator();
      Assert.AreEqual("7", translator.Translate("t"));
    }
    [TestMethod]
    public void Translate_ReplaceNotFirstSWithZ()
    {
      LeetspeakTranslator translator = new LeetspeakTranslator();
      Assert.AreEqual("3z", translator.Translate("Es"));
      Assert.AreEqual("s", translator.Translate("s"));
    }
  }
}
