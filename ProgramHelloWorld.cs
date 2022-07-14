// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      // Level1
      Console.WriteLine("Hello World!");

      // Level2
      Console.WriteLine("What is your name?");
      var name = Console.ReadLine();
      var currentDate = DateTime.Now;
      Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
      Console.Write($"{Environment.NewLine}Press any key to exit...");
      Console.ReadKey(true);
    }
  }
}