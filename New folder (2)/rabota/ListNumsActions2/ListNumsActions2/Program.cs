using System;
using System.Collections.Generic;
using System.Linq;

namespace ListNumsActions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while (true)
            {
                command = Console.ReadLine().Trim().ToLower();
                if (command == "finish") break;

                string[] parts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = parts[0];

                switch (action)
                {
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;

                    case "ins":
                        int index = int.Parse(parts[1]);
                        int element = int.Parse(parts[2]);
                        if (index >= 0 && index <= numbers.Count)
                            numbers.Insert(index, element);
                        break;

                    case "del":
                        int value = int.Parse(parts[1]);
                        numbers.Remove(value);
                        break;

                    case "contains":
                        int checkValue = int.Parse(parts[1]);
                        Console.WriteLine(numbers.Contains(checkValue) ? "Yes" : "No");
                        break;

                    case "remove":
                        int removeIndex = int.Parse(parts[1]);
                        if (removeIndex >= 0 && removeIndex < numbers.Count)
                            numbers.RemoveAt(removeIndex);
                        break;

                    case "add":
                        int a = int.Parse(parts[1]);
                        int b = int.Parse(parts[2]);
                        numbers.Add(a + b);
                        break;

                    case "countl":
                        int limit = int.Parse(parts[1]);
                        int countL = numbers.Count(x => x > limit);
                        Console.WriteLine($"CountL={countL}");
                        break;

                    case "countodds":
                        int oddCount = numbers.Count(x => x % 2 != 0);
                        Console.WriteLine($"CountOdds={oddCount}");
                        break;

                    case "countevens":
                        int evenCount = numbers.Count(x => x % 2 == 0);
                        Console.WriteLine($"CountEvens={evenCount}");
                        break;

                    case "sumall":
                        Console.WriteLine($"SumAll={numbers.Sum()}");
                        break;

                    default:
                        Console.WriteLine("Unknown command!");
                        break;
                }
            }
        }
    }
}
