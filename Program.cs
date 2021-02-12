using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Tasks_Random_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[] numbers = new int[30];
            int numZeroes = 0;

            // Fills array
            for (int i = 0; i < 30; i++)
                numbers[i] = generator.Next(50);

            // 1 Displays the array
            Console.WriteLine("Here are the random numbers:");
            for (int i = 0; i < 30; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
            Console.WriteLine("The largest number is " + numbers.Max());
            Console.WriteLine("The smallest number is " + numbers.Min());
            Console.WriteLine("The average is " + numbers.Average());
            
            // 2 Loops through and prints Ten, Twenty, Thirty and Fourty instead of numberical values
            Console.WriteLine();
            Console.WriteLine("Here are the random numbers again but with words for 10, 20, 30 and 40:");
            for (int i = 0; i < 30; i++)
            {
                if (numbers[i] == 10)
                    Console.Write("Ten ");
                else if (numbers[i] == 20)
                    Console.Write("Twenty ");
                else if (numbers[i] == 30)
                    Console.Write("Thirty ");
                else if (numbers[i] == 40)
                    Console.Write("Fourty ");
                else
                    Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // 3 - Double each number
            for (int i = 0; i < 30; i++)
                numbers[i] = numbers[i] * 2;

            // 4 - Replace all values less than 50 with zero
            for (int i = 0; i < 30; i++)
            {
                if (numbers[i] < 50)
                    numbers[i] = 0;
            }

            // 5 - Display the values after changes have been made
            Console.WriteLine("Here are the random numbers again:");
            for (int i = 0; i < 30; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
            Console.WriteLine();

            // 6 - Count the number of zeroes
            for (int i = 0; i < 30; i++)
                if (numbers[i] == 0)
                    numZeroes += 1;
            Console.WriteLine("There are " + numZeroes + " zeroes");


            Console.ReadLine();
        }
    }
}
