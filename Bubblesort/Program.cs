using System;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {

            // Opgave A

            int[] tal = new int[10];
            Random random = new Random();

            for (int i = 0; i < tal.Length; i++)
            {
                int randomNumber = random.Next(0, 1000);
                tal[i] = randomNumber;
            }

            // Opgave B


            Console.WriteLine("Before sorting: ");

            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine(tal[i]);
            }

            for (int i = 0; i <= tal.Length; i++)
            {
                for (int j = 0; j < (tal.Length - 1) - i; j++)
                { 
                    if (tal[j] > tal[j + 1])
                    { 
                      int temp = tal[j + 1];
                      tal[j + 1] = tal[j];
                      tal[j] = temp;

                    }

                }

            }
            Console.WriteLine("After sorting:");

            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine(tal[i]);
            }


            Array.Reverse(tal);
            Console.WriteLine("After reversing:");
            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine(tal[i]);
            }
            Console.ReadKey();
        }
    }
}
