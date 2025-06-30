using System;

class Program
{
    static void Main()
    {
        // ===============================
        #region Question 1
        // 1- Write a program that takes a number from the user 
        // then print yes if that number can be divided by 3 and 4 otherwise print no.
        // Example (1): Input: 12 -> Output: Yes
        // Example (2): Input: 9  -> Output: No

        Console.WriteLine("Question 1:");
        Console.Write("Enter a number: ");
        int num1 = int.Parse(Console.ReadLine());

        if (num1 % 3 == 0 && num1 % 4 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        Console.WriteLine();
        #endregion

        // ===============================
        #region Question 2
        // 2- Write a program that allows the user to insert an integer
        // then print negative if it is negative number otherwise print positive.
        // Example: Input: -5 → Output: negative

        Console.WriteLine("Question 2:");
        Console.Write("Enter a number: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num2 < 0)
        {
            Console.WriteLine("negative");
        }
        else
        {
            Console.WriteLine("positive");
        }
        Console.WriteLine();
        #endregion

        // ===============================
        #region Question 3
        // 3- Write a program that takes 3 integers from the user 
        // then prints the max element and the min element.
        // Example: Input: 7, 8, 5 → Output: Max = 8, Min = 5

        Console.WriteLine("Question 3:");
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        int max = Math.Max(a, Math.Max(b, c));
        int min = Math.Min(a, Math.Min(b, c));

        Console.WriteLine("Max element = " + max);
        Console.WriteLine("Min element = " + min);
        Console.WriteLine();
        #endregion

        // ===============================
        #region Question 4
        // 4- Write a program that allows the user to insert an integer number 
        // then check if a number is even or odd.

        Console.WriteLine("Question 4:");
        Console.Write("Enter a number: ");
        int num4 = int.Parse(Console.ReadLine());

        if (num4 % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
        Console.WriteLine();
        #endregion

        // ===============================
        #region Question 5
        // 5- Write a program that takes character from the user 
        // then if it is a vowel (a, e, i, o, u) then print vowel 
        // otherwise print consonant.
        // Example: Input: O → Output: vowel

        Console.WriteLine("Question 5:");
        Console.Write("Enter a character: ");
        char ch = char.ToLower(Console.ReadLine()[0]);

        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("consonant");
        }
        Console.WriteLine();
        #endregion

        // ===============================
        Console.WriteLine("All questions completed.");
    }
}

