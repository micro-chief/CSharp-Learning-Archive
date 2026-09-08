using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace код_номер_1488
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int n;
            n = rnd.Next(2,3); 
            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 100);
            }
            var str = string.Join(" ", numbers);
            Console.WriteLine(str);
            int outlier = FindOutlier(numbers);
            Console.WriteLine("Выброс: " + outlier);
        }
        static int FindOutlier(int[] arr)
        {
            int oddCount = 0;
            int evenCount = 0;
            int oddNumber = 0;
            int evenNumber = 0;

            foreach (int num in arr)
            {

                if (num % 2 == 0)
                {
                    evenCount++;
                    evenNumber = num;
                }
                else
                {
                    oddCount++;
                    oddNumber = num;
                }
            }
            Console.WriteLine();
            return (evenCount == 1) ? evenNumber : oddNumber;
        }
    }
    
}
