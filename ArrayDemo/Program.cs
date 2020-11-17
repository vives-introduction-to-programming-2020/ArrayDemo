using System;

namespace ArrayDemo
{
    class Program
    {
        // MOTD = Message of the Day (spreuk / bericht)
        public static string MessageOfTheDay()
        {
            Random generator = new Random();

            string[] messages =
            {
                "Be happy and not afraid.",
                "One apple a day keeps the doctor away",
                "You need glasses to CSharp",
                "A fish is not a rock",
                "There is no place like home",
                "You cannot change your fate, no man can ..."
            };

            return messages[generator.Next(messages.Length)];
        }

        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static double Average(int[] numbers)
        {
            // return 1.0 * Sum(numbers) / numbers.Length;
            // return (double) Sum(numbers) / numbers.Length;
            return Convert.ToDouble(Sum(numbers)) / numbers.Length;
        }

        // Minimum bepalen uit lijst van getallen?????
        public static int Minimum(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            // Make a copy
            //int[] sorted = new int[numbers.Length];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sorted[i] = numbers[i];
            //}

            // Make a copy
            int[] sorted = (int[])numbers.Clone();
            Array.Sort(sorted);
            return sorted[0];
        }

        public static int MinimumPosition(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return -1;
            }

            int iMinimum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[iMinimum])
                {
                    iMinimum = i;
                }
            }
            return iMinimum;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * i;
                Console.WriteLine("Number: " + numbers[i]);
            }

            double[] values = {
                12.3,   // index = 0
                43.6,
                88.9,
                77.23   // index = 3
            };  // Length = 4

            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("Value: " + values[i]);

                sum += values[i];
            }
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + sum/values.Length);

            Console.WriteLine(MessageOfTheDay());

            int sumOfNumbers = Sum(numbers);
            Console.WriteLine("Sum of numbers = " + sumOfNumbers);
            Console.WriteLine("Average of numbers = " + Average(numbers));


            int[] someNumbers = { 54, 23, 12, 1, 8, 56 };
            Console.WriteLine("Minimum: " + Minimum(someNumbers));
            for (int i = 0; i < someNumbers.Length; i++)
            {
                Console.WriteLine("SomeNumbers: " + someNumbers[i]);
            }

            int[] emptyArray = { };
            Console.WriteLine("Minimum: " + Minimum(emptyArray));

            int[] otherNumbers = { 45, 342, 45, 4, 0, -12, 88 };
            Console.WriteLine("iMinimum = " + MinimumPosition(otherNumbers));

            // EMpty array
            Console.WriteLine("iMinimum EMPTY = " + MinimumPosition(emptyArray));
        }
    }
}
