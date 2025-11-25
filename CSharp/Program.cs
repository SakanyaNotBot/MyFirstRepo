using System;

namespace JustRepo;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World");
        Greeting.Greet();
    }
}
public class Greeting
{
    public static void Greet()
    {
        Console.WriteLine("Greetings from sakanya!");
    }
}