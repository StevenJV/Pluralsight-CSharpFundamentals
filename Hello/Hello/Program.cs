using System;

namespace Hello
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Your name:");
      string name = Console.ReadLine();

      Console.WriteLine("How many hours of sleep did you get last night? ");
      int hoursOfSleep = int.Parse(Console.ReadLine());

      Console.WriteLine("Hello, " + name);
      if (hoursOfSleep > 8)
      {
        Console.WriteLine("you are well rested.");
      }
      else
      {
        Console.WriteLine("you need more sleep.");
      }
    }
  }
}
