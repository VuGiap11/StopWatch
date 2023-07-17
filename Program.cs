using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SW stopwatch = new SW();
            stopwatch.Start();

            SapXep1();

            stopwatch.Stop();
            Console.WriteLine(" tong thoi gian sap xem la : {0}", stopwatch.GetELapsedTime());

            stopwatch.Start();

            SapXep2();

            stopwatch.Stop();
            Console.WriteLine(" tong thoi gian sap xem la : {0}", stopwatch.GetELapsedTime());



        }
        private static void SapXep1()
        {
            int[] arr = new int[100000];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1000000);
            }
            Array.Sort(arr);

        }
        private static void SapXep2()
        {
            List<int> numberS = new List<int>();

            Random random = new Random(); 
            for (int i = 0; i < 100000; i++)
            {
                numberS.Add(random.Next(100000));
            }   

            numberS.Sort();
        }
    }
}
