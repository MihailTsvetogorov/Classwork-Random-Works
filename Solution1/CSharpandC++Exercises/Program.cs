using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpandC__Exercises
{
    /*class ExerciseOne
    {
        //Checks number if compatible
        static int checkNumber(int number)
        {
            while (number <= 1 || number >= 15000)
            {
                number = int.Parse(Console.ReadLine());
            }
            return number;
        }
        //Checks Digits in Nubmber
        static void numberDigits(int number)
        {
            int countOfDigits = 0;
            for (int i = 0; number > 0; i++)
            {
                number /= 10;
                countOfDigits++;
            }
            Console.WriteLine("The number of digits is {0}", countOfDigits);
        }
        //Sum of the Number's Digits
        static void sumOfDigits(int number)
        {
            int sum = 0;
            for (; number > 0; )
            {
                sum += (number % 10);
                number /= 10;
            }
            Console.WriteLine("The sum of the digits is {0}", sum);
        }
        //Main Method
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            N = checkNumber(N);
            numberDigits(N);
            sumOfDigits(N);
        }
    }*/
    /*class ExerciseTwo
    {  
        //Sets up needed things
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
                return getrandom.Next(min, max);
        }
        //Gets the Random Numbers For the Game
        static int[] fillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GetRandomNumber(1, 50);
            }
            return array;
        }
        //Prints an Array
        static int[] printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            return array;
        }
        //Main Method
        static void Main(string[] args)
        {
            int[] totoNumbers = new int[6];
            fillArray(totoNumbers);
            printArray(totoNumbers);
        }
    }*/
    /*class ExerciseThree
    {
        //Main Method - checks how many times does the letter 'a' contain in the string
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] wordInArray = word.ToCharArray();
            int countsOfA = wordInArray.Where(x => x == 'a').Count();
            Console.WriteLine(countsOfA);                                                                                                                                                                                                                                                                                                                    
        }
    }*/
    /*class ExerciseFour
    {
        //Checks if the number is in the array
        public static void checkIfTheNumberIsInTheArray(int[] checkArray, int number)
        {
            int count = 0;
            for (int i = 0; i < checkArray.Length-1; i++)
            {
                if (checkArray[i] == number)
                {
                    count++;
                    break;
                }
            }
            if (count == 0) Console.WriteLine("No");
            else Console.WriteLine("Yes");
        }

        //Main Method
        static void Main(string[] args)
        {
            int[] checkNumbers = 
                Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            int number = int.Parse(Console.ReadLine());
            checkIfTheNumberIsInTheArray(checkNumbers, number); 
        }
    }*/
    class ExerciseFive
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char[] number1ToArray = number1.ToString().ToCharArray();
            char[] number2ToArray = number1.ToString().ToCharArray();
            int countGroup = 0;
            int count = 0;
                for (int j = 0; j < number2ToArray.Length; j++)
                {
                    if (number1ToArray[j] == number2ToArray[j]) countGroup++;
                    else if (countGroup == 3)
                    {
                        count++;
                        countGroup = 0;
                    }
                    else countGroup = 0;
                }
        }
    }
}

