using System;
using System.Collections.Generic;

namespace solo_prep_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
            int userNum = 1;
            while (userNum != 0) {
                Console.Write("Enter number: ");
                string userNumStr = Console.ReadLine();
                userNum = int.Parse(userNumStr);
                if (userNum != 0) {
                    numbers.Add(userNum);
                } else {
                    break;
                }
            }
            int sum = 0;
            int average = 0;
            int max = numbers[1];
            int min = numbers[1];

            foreach (int number in numbers) {
                sum += number;
                if (number < min) {
                    min = number; 
                } else if (number > max) {
                    max = number;
                }
            }
            average = sum / numbers.Count;
            Console.WriteLine($"The total is {sum}. ");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Average: {average}");

        }
    }
}
