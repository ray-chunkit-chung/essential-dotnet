using StringLibrary;

class Program
{
  static void Main(string[] args)
  {
    // Example 1: Hello World
    // See https://aka.ms/new-console-template for more information
    Console.WriteLine("Input name:");
    var name = Console.ReadLine();
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Hello, World!2");
    Console.WriteLine($"Hello, World!3. {name}");
    Console.WriteLine("Hello, World!4");


    // Example2: String starts with upper
    while (true)
    {
      // Get input string
      Console.WriteLine("Input string");
      string? str = Console.ReadLine();
      if (string.IsNullOrEmpty(str)) break;

      // result is true if str StartsWithUpper  
      var result = str.StartsWithUpper();
      Console.WriteLine($"String begins with uppercase: {result}");
    }
  }
}
