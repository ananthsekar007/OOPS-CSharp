using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Async2
    {
        public static async Task<string> method1()
        {
            Console.WriteLine("Hello 1 started");
            Console.WriteLine("Message in method1");

            Console.WriteLine(await Async2.method2());
            Console.WriteLine("Hello 1 ended");
            return "completed method1";
        }

        public static async Task<string> method2()
        {
            Console.WriteLine("Hello 2 started");
            Task.Delay(7000);
            string msg = "Mesage from method2";
            Console.WriteLine("Hello 2 ended");
            return msg;
        }

        public static async Task<int> method3()
        {
            Console.WriteLine("dummy method");
            return 3;


        }
        static void Main(string[] args)
        {
            var calculation = new System.Diagnostics.Stopwatch();
            calculation.Start();
            Async2.method1();
            //Program.method1();
            Console.WriteLine("Calling method3");
            int ans = Async2.method3().Result;
            Console.WriteLine("ans " + ans);

            calculation.Stop();
            Console.WriteLine("Elapsed time:" + calculation.ElapsedMilliseconds);
            Console.ReadLine();

        }


    }
}
