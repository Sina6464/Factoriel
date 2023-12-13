using System;

class Factorial
{
    static void Main()
    {
        //سینا شاهینی فاکتوریل
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        decimal factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("Factorial of " + num + " is: " + factorial);
        Console.ReadKey();
    }
}