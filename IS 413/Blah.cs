namespace IS_413;

public class Blah
{
    public Blah()
    {
        //Method called one time on setup in the beginning
        Console.WriteLine("Hi");
    } 
    
    public void SecondMethod(int age, string name)
    {
        age = age * 7;
        
        Console.WriteLine(age);
    }

    public void SecondMethod(string name = "Hi")
    {
        int age = 25;
    }
}