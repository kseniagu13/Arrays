using System;

namespace randomArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5] { 3, 6, 4, 7, 5 };
            int min = Int32.MaxValue; // maximum mida on võimeline salvestada

            foreach (int number in numbers)
            {
                if (number < min) // alguses võrdleb 3 ja max value, siis võtab juba 6 ja võrdleb 3ga, siis 4 võrdleb 6ga jne.
                {
                    min = number;
                }
            }
            Console.WriteLine($"The minimum value is {min}");

            int max = Int32.MinValue;

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The maximum value is {max}");
        }

        // kasutaja annab sõna. Kontrollime, kas see sõna on palindrome.
    }
}
