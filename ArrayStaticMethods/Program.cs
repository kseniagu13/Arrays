using System;

namespace ArrayStaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] fruit = new string[5] { "apple", "banana", "pear", "orange", "lemon" };
           
            PrintArray(fruit);

            //Get the element index
            int index;
            int index2;
            string userAnswer;
            index = Array.IndexOf(fruit, "mango");
            Console.WriteLine($"The index of your element is: {index}");

            Console.WriteLine("Write your fruit: ");
            userAnswer = Console.ReadLine();
            index2 = Array.IndexOf(fruit, userAnswer);
            if (index2 == -1) // != -1, tähendab, et ei ole võrdne -1 ehk
            {
                Console.WriteLine("Your fruit is doesnt include in Array");
            }
            else
            { 
                Console.WriteLine($"The index of your element is: {index2}");
            }



            /*for(int i = 0; i < colours.Length; i++)
            {
                Console.WriteLine("Enter a colour: ");
                colours[i] = Console.ReadLine();
            }
            //Sort an array  tähestiku järjekorras
            Array.Sort(colours); //alguses peab sorteerima ja siis reverse, kui tahame sorteerida tagurpidi
            Console.WriteLine("\n");
            PrintArray(colours);
            Console.WriteLine("\n");

            //Reverse an array  //tähestiku tagurpidu järjekorras
            Array.Reverse(colours);
            PrintArray(colours);

            /* foreach (string colour in colours) // tegime selle jaoks funktsiooni, et mitte repeat yourself
             {
                 Console.WriteLine(colour);
             }*/
        }

        public static void PrintArray(string[] array)
        {
            foreach (string item in array) //tegime funktsiooni, et kutsuda massiivi välja milal me tahame.
            {
                Console.WriteLine(item);
            }
        }
    }
}
