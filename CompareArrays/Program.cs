using System;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] fruits = new string[5] { "apple", "banana", "orange", "pear", "lemon" };
            String[] vegetables = new string[5] { "potato", "carrot", "tomato", "onion", "cucumber" };

            string userAnswer;
            int index;
            int index2;
            Console.WriteLine("Choose fruit or vegetable: ");
            userAnswer = Console.ReadLine();
            index = Array.IndexOf(fruits, userAnswer);
            index2 = Array.IndexOf(vegetables, userAnswer);
            Console.WriteLine(index);
            Console.WriteLine(index2);

            if (index != -1)
            {
                Console.WriteLine("Your element is fruit");
            }
            else if (index2 !=-1)
            {
                Console.WriteLine("Your element is vegetable");
            }
            else
            {
                Console.WriteLine("Your element is not found!");
            }



        }
        

    } 
}
