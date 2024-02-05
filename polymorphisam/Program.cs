using System;
public class Addition
{
    public int Add(int a, int b)
    {
return a + b;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
    public string Add(String a, String b)
    {
        return a + b;
    }
}
class Program
{
    public static void Main()
    {
        Addition addition = new Addition();

       int resultint = addition.Add(1, 2);
        Console.WriteLine(resultint);
        double resultdouble = addition.Add(1.77, 2.0);
        Console.WriteLine(resultdouble);
        string resultstring = addition.Add("hi", "hello");
        Console.WriteLine(resultstring);
    }
}