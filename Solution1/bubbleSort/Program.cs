using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();
            string[] secondArray = Console.ReadLine().Split().ToArray();
            int count = 0;
            if (firstArray.Length > secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    for (int j = 0; j < secondArray.Length; j++)
                    {
                        if (firstArray[i] == secondArray[j]) count++;
                    }
                }   
            }
            else if (firstArray.Length > secondArray.Length)
            {
                for (int i = 0; i < length; i++)
                {
                    
                }
            }
            Console.WriteLine(count);
        }

    }
}