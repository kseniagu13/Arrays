using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearOfBirth;
            int age; //muutujat deklareerin Mainis aga vastust saan funkstioonist
            Console.WriteLine("What is your year of birth?");
            yearOfBirth = int.Parse(Console.ReadLine());
            age = CalculateAge(yearOfBirth, 2019); //2019 on currentYear
            Console.WriteLine($"You are {age} years old.");

            int ageNextYear = CalculateNextYearAge(age);
            Console.WriteLine($"You are next year {ageNextYear} years old.");

           CalculateDiffernece(yearOfBirth);


        }
        public static int CalculateAge(int yearOfBirth, int currentYear)
        {
            /*int result = currentYear - yearOfBirth;
            return result;*/  //see on pikkem tee

            return currentYear - yearOfBirth; //see on lühem tee
        }
        public static int CalculateNextYearAge(int userAge)
        {
            return userAge + 1;
        }

        public static void CalculateDiffernece (int yearOfBirth)
        {
            if (yearOfBirth > 1926)
            {
              Console.WriteLine($" You are {yearOfBirth - 1926} year(s) younger than the Queen.");
            }
            else if (yearOfBirth < 1926)
            {
                Console.WriteLine($" You are {1926 - yearOfBirth} year(s) older than the Queen.");
            }
            else
            {
                Console.WriteLine($" Are you the Queen?.");
            }
            
        }
    }
}
