using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Massiivide puhul peab teadma, mitu kastikest me kasutame

            int[] myFirstArray = new int[5] { 1, 2, 3, 4, 5 }; //massiiv on nagu klass, peab alustana deklareerimisest new int ja mitu indexit me tahame

            /* Console.WriteLine(myFirstArray);
             Console.WriteLine(myFirstArray[0]); //saab käsitsi nii välja kutsuda või 
             for (int i = 0; i < myFirstArray.Length; i++) // saab kutsuda välja for-ga, foreach-ga, whilega
             {
                 Console.WriteLine(myFirstArray[i]);
             }
             for (int i = myFirstArray.Length -1; i >= 0; i--) // saab kutsuda välja for-ga, foreach-ga, whilega, alustame 4st , sest 4 on 5 aadress ja lõpetab aadressiga 0. i-- tähendab üks samm miinus
             {
                 Console.WriteLine(myFirstArray[i]);
             } */

            /* myFirstArray[4] = myFirstArray[4] * 100;
            for (int i = 0; i < myFirstArray.Length; i++)
            {
                Console.WriteLine(myFirstArray[i]);
            }

            myFirstArray[0] = myFirstArray[0] * 100;
            for(int i = 0; i < myFirstArray.Length; i++)
            {
                Console.WriteLine(myFirstArray[i]);
            }*/

            for (int i =0; i < myFirstArray.Length; i++) // korraga korrutame kõik väärtused 100ga
            {
                myFirstArray[i] = myFirstArray[i] * 100;
                Console.WriteLine(myFirstArray[i]);
            }



        }
    }
}
