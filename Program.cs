using System;

class Program
{
    static void Main()
    {
        Question6.Run();
    }
}

#region Question 6
// Print numbers from 1 to input number
class Question6
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            Console.Write(i + " ");
        }
    }
}
#endregion

#region Question 7
// Multiplication table up to 12
class Question7
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 12; i++)
        {
            Console.Write(num * i + " ");
        }
    }
}
#endregion

#region Question 8
// Print even numbers between 1 and input number
class Question8
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 2; i <= num; i += 2)
        {
            Console.Write(i + " ");
        }
    }
}
#endregion

#region Question 9
// Power of two numbers
class Question9
{
    public static void Run()
    {
        Console.Write("Enter base: ");
        int baseNum = int.Parse(Console.ReadLine());
        Console.Write("Enter exponent: ");
        int exp = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 0; i < exp; i++)
        {
            result *= baseNum;
        }

        Console.WriteLine("Result: " + result);
    }
}
#endregion

#region Question 10
// Total, Average, and Percentage of 5 subjects
class Question10
{
    public static void Run()
    {
        int[] marks = new int[5];
        int total = 0;

        Console.WriteLine("Enter marks of 5 subjects:");
        for (int i = 0; i < 5; i++)
        {
            marks[i] = int.Parse(Console.ReadLine());
            total += marks[i];
        }

        float average = total / 5f;
        float percentage = (total / 500f) * 100;

        Console.WriteLine("Total = " + total);
        Console.WriteLine("Average = " + average);
        Console.WriteLine("Percentage = " + percentage);
    }
}
#endregion

#region Question 11
// Days in month
class Question11
{
    public static void Run()
    {
        Console.Write("Enter month number (1-12): ");
        int month = int.Parse(Console.ReadLine());
        int days;

        switch (month)
        {
            case 2: days = 28; break;
            case 4:
            case 6:
            case 9:
            case 11:
                days = 30; break;
            default:
                days = 31; break;
        }

        Console.WriteLine("Days in Month: " + days);
    }
}
#endregion

#region Question 12
// Simple Calculator
class Question12
{
    public static void Run()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        char op = char.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = 0;
        bool valid = true;

        switch (op)
        {
            case '+': result = num1 + num2; break;
            case '-': result = num1 - num2; break;
            case '*': result = num1 * num2; break;
            case '/':
                if (num2 != 0) result = num1 / num2;
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                    valid = false;
                }
                break;
            default:
                Console.WriteLine("Invalid operator.");
                valid = false;
                break;
        }

        if (valid)
            Console.WriteLine("Result = " + result);
    }
}
#endregion

#region Question 13
// Reverse a string
class Question13
{
    public static void Run()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] arr = input.ToCharArray();
        Array.Reverse(arr);

        Console.WriteLine("Reversed: " + new string(arr));
    }
}
#endregion

#region Question 14
// Reverse an integer
class Question14
{
    public static void Run()
    {
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        int reversed = 0;

        while (num != 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }

        Console.WriteLine("Reversed: " + reversed);
    }
}
#endregion

#region Question 15
// Prime numbers in a range
class Question15
{
    public static void Run()
    {
        Console.Write("Enter start number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter end number: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime numbers between {0} and {1}:", start, end);
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
                Console.Write(i + " ");
        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
            if (num % i == 0) return false;
        return true;
    }
}
#endregion

#region Question 17
// Check if 3 points lie on one line
class Question17
{
    public static void Run()
    {
        Console.WriteLine("Enter (x1, y1): ");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter (x2, y2): ");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter (x3, y3): ");
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            Console.WriteLine("Points lie on a straight line.");
        else
            Console.WriteLine("Points do not lie on a straight line.");
    }
}
#endregion

#region Question 18
// Worker efficiency
class Question18
{
    public static void Run()
    {
        Console.Write("Enter time taken by worker (in hours): ");
        double time = double.Parse(Console.ReadLine());

        if (time >= 2 && time < 3)
            Console.WriteLine("Highly efficient.");
        else if (time >= 3 && time < 4)
            Console.WriteLine("Improve your speed.");
        else if (time >= 4 && time <= 5)
            Console.WriteLine("Training required.");
        else if (time > 5)
            Console.WriteLine("You are required to leave the company.");
        else
            Console.WriteLine("Invalid input.");
    }
}
#endregion
