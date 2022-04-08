using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber_Sqr_Sum a = new PrimeNumber_Sqr_Sum();
            List<int> c = a.enter();
            a.checkprime(c);


        }
        public class PrimeNumber_Sqr_Sum
        {
            public List<int> checkprime(List<int> numbers)
            {
                List<int> primeList = new List<int>();
                foreach (var nums in numbers)
                {
                    int flag = 0; //for prime numbers
                                  //change flag = 1 if 1 is in the list
                    if (nums == 1)
                    {
                        flag = 1;
                    }
                    if (nums > 1)
                    {
                        for (int j = 2; j < nums; j++)
                        {
                            if (nums % j == 0)
                            {
                                flag = 1;
                                break;
                            }
                        }
                    }
                    if (flag == 0)
                    {
                        primeList.Add(nums);
                    }
                }
                //display prime numbers list
                Console.WriteLine("\nPrinting the Prime List: ");
                foreach (var num in primeList)
                {
                    Console.WriteLine(num);
                }
                //display sum of squares of all primeList elements
                Console.WriteLine("\nSum of Squares is: " + primeList.Sum(n => n * n));
                return primeList;


            }


            public List<int> enter()
            {
                List<int> numbers = new List<int>();
                Console.WriteLine("Enter the no.");
                int size = Convert.ToInt32(Console.ReadLine());
                numbers.Add(size);
                for (int num = 1; num < size; num++)
                {
                    Console.WriteLine($"Enter {num} values");
                    int values = Convert.ToInt32(Console.ReadLine());
                    numbers.Add(values);
                }
                Console.WriteLine("Entered no.");
                foreach (int num in numbers)
                {

                    Console.Write($" {num} ");
                }

                return numbers;

            }
        }
    } 
}
