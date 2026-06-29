using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int num = -1;
        float total = 0;
        float average = 0;
        int max = 0;
        int min = 99999999;
        List<int> numbers = new List<int>();
        while (num != 0)
        {
            Console.Write("Enter a number. ");
            string entry = Console.ReadLine();
            num = int.Parse(entry);
            if (num != 0)
            {
                numbers.Add(num);
            }
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            total += numbers[i];
            if (max < numbers[i])
            {
                max = numbers[i];
            }
            if (numbers[i] < min && numbers[i] > 0)
            {
                min = numbers[i];
            }
        }
        Console.WriteLine($"The total is: {total}");
        average = total / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The highest number is: {max}");
        Console.WriteLine($"Small positive number is: {min}");
        numbers.Sort();
        Console.WriteLine($"The sorted list is:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}