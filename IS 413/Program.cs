// See https://aka.ms/new-console-template for more information

using IS_413;

internal class Program
{
    public static void Main(string[] args)
    {
        Blah b1 = new Blah();
        Blah b2 = new Blah();
        
        Console.WriteLine("Hello, World!");
        
        b1.SecondMethod(age:23, name:"Madison");
        b2.SecondMethod(age:40, name:"Spencer");
    }
}