using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetEvenNumber();

            //thread1();
            //thread2();

            Thread t1 = new Thread(thread1);
            t1.Start();

            Thread t2 = new Thread(thread2);
            t2.Start();
        }

        private static void thread1()
        {
            for (int i =0; i< 10; i++)
            {
                Console.WriteLine($"thread 1 : {i}");
                Thread.Sleep(2000);
            }
        }

        private static void thread2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"thread 2 : {i}");
                Thread.Sleep(2000);
            }
        }

        static void GetEvenNumber()
        {
            List<int> numbers = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            List<int> evenNumber = new List<int>();

            // 방법1
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumber.Add(num);
                }
            }

            foreach (int num in evenNumber)
            {
                Console.WriteLine(num);
            }


            // 방법2 (Linq)
            List<int> evenNumber2 = (from num
                               in numbers
                                     where num % 2 == 0
                                     select num).ToList();

            foreach (int num in evenNumber2)
            {
                Console.WriteLine(num);
            }

            // 방법3 (무명메서드)
            var evenNumber3 = numbers.Where(x => x % 2 == 0);

            foreach (int num in evenNumber3)
            {
                Console.WriteLine(num);
            }
        }
    }
}
