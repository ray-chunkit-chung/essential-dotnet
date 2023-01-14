using StringLibrary;

namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
  [TestMethod]
  public void TestStartsWithUpper()
  {
    string[] words = { "A", "B", "C" };
    foreach (string word in words)
    {
      bool result = word.StartsWithUpper();
      Assert.IsTrue(
        result,
        string.Format("Expected for '{0}': true; Actual: {1}", word, result)
      );
    }
  }
  [TestMethod]
  public void TestInteger()
  {
    string[] words = { "1", "2", "3", null };
    foreach (string word in words)
    {
      bool result = word.StartsWithUpper();
      Assert.IsFalse(
        result,
        string.Format("Expected for '{0}': false; Actual: {1}", word, result)
      );
    }
  }
}