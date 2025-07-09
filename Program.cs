using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        Question19.Run();
      
    }
}

#region Question 19
class Question19
{
    public static void Run()
    {
        Console.Write("Enter size of identity matrix: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(i == j ? "1 " : "0 ");
            }
            Console.WriteLine();
        }
    }
}
#endregion

#region Question 20
class Question20
{
    public static void Run()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        int sum = arr.Sum();
        Console.WriteLine("Sum = " + sum);
    }
}
#endregion

#region Question 21
class Question21
{
    public static void Run()
    {
        Console.Write("Enter size of arrays: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        Console.WriteLine("Enter elements of first array:");
        for (int i = 0; i < n; i++)
            arr1[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of second array:");
        for (int i = 0; i < n; i++)
            arr2[i] = int.Parse(Console.ReadLine());

        int[] merged = arr1.Concat(arr2).ToArray();
        Array.Sort(merged);

        Console.WriteLine("Merged and sorted array:");
        Console.WriteLine(string.Join(" ", merged));
    }
}
#endregion

#region Question 22
class Question22
{
    public static void Run()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Dictionary<int, int> freq = new Dictionary<int, int>();

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (freq.ContainsKey(arr[i]))
                freq[arr[i]]++;
            else
                freq[arr[i]] = 1;
        }

        Console.WriteLine("Element frequencies:");
        foreach (var item in freq)
            Console.WriteLine($"{item.Key} occurs {item.Value} times");
    }
}
#endregion

#region Question 23
class Question23
{
    public static void Run()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        int min = arr.Min();
        int max = arr.Max();

        Console.WriteLine("Minimum = " + min);
        Console.WriteLine("Maximum = " + max);
    }
}
#endregion

#region Question 24
class Question24
{
    public static void Run()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Array.Sort(arr);
        Array.Reverse(arr);

        int first = arr[0];
        int secondLargest = -1;

        for (int i = 1; i < n; i++)
        {
            if (arr[i] != first)
            {
                secondLargest = arr[i];
                break;
            }
        }

        Console.WriteLine("Second largest = " + (secondLargest == -1 ? "Not found" : secondLargest.ToString()));
    }
}
#endregion

#region Question 25
class Question25
{
    public static void Run()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        int maxDistance = 0;
        Dictionary<int, int> firstIndex = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            if (!firstIndex.ContainsKey(arr[i]))
                firstIndex[arr[i]] = i;
            else
                maxDistance = Math.Max(maxDistance, i - firstIndex[arr[i]] - 1);
        }

        Console.WriteLine("Longest distance between equal cells: " + maxDistance);
    }
}
#endregion

#region Question 26
class Question26
{
    public static void Run()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        Array.Reverse(words);
        Console.WriteLine(string.Join(" ", words));
    }
}
#endregion

#region Question 27
class Question27
{
    public static void Run()
    {
        Console.Write("Enter rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] arr1 = new int[rows, cols];
        int[,] arr2 = new int[rows, cols];

        Console.WriteLine("Enter values for first array:");
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                arr1[i, j] = int.Parse(Console.ReadLine());

        // Copy elements
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                arr2[i, j] = arr1[i, j];

        Console.WriteLine("Second array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(arr2[i, j] + " ");
            Console.WriteLine();
        }
    }
}
#endregion

#region Question 28
class Question28
{
    public static void Run()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Array.Reverse(arr);
        Console.WriteLine("Reversed array:");
        Console.WriteLine(string.Join(" ", arr));
    }
}
#endregion
