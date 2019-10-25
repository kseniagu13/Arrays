using System;

namespace Array.String
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] myFirstStringArray = new string[5] { "one", "two", "three", "four", "five" };

            for (int i=0; i < myFirstStringArray.Length; i++)
            {
                Console.WriteLine(myFirstStringArray[i]);
            }

            for (int  i= myFirstStringArray.Length-1; i >=0; i--) //loeme tagurpidi
            {
                Console.WriteLine(myFirstStringArray[i]);
            }*/

            /* string[] fruits = new string[5];

             for (int i = 0; i<5; i++)
             {
                 Console.WriteLine("Name some fruit: ");
                 fruits[i] = Console.ReadLine();
             }

             foreach(string fruit in fruits)
             {
                 Console.WriteLine($"You have entered: {fruit}"); 
             } */


            // massiv 1-100 elementi , leidke nende elementide summa. peab esialgu muutujat tegema sum=0.

            int[] numbers = new int[100]; //100 elementide arv
            int sum = 0;
            int sumAverage = 0;
            for (int i=0; i<numbers.Length; i++) //alustan i=0, et ta alustaks täitsa esimesest elemendist
            {
                numbers[i] = i + 1;
            }
            foreach(int num in numbers)
            {
                //Console.WriteLine(num);
                sum = sum + num;
            }

            Console.WriteLine(sum);
            sumAverage = sum / numbers.Length; //summade keskmine 
            Console.WriteLine(sumAverage);


            Console.ReadLine();


        }
    }
}
