using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 20, 15, 1, 8, 76, 51, 99, 35, 48, 12 };

            while (true)
            {
                Console.Write("Enter value to find (or type 'exit' to quit): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                if (int.TryParse(input, out int userIput))
                {
                    int index = SearchArray(num, userIput);
                    if (index != -1)
                    {
                        Console.WriteLine($"The target item was found at location: {index}");
                    }
                    else
                    {
                        Console.WriteLine("The target item was not found in the list");
                    }

                    Console.Write("Target List contains values: ");
                    DisplayArrVals(num);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }

        public static int SearchArray(int[] numbers, int num)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }

        private static void DisplayArrVals(int[] numbers)
        {
            string output = string.Join("|", numbers);
            Console.WriteLine(output);
        }
    }

}

