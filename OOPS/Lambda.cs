using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    delegate void Sum(int a, int b);
    internal class Lambda
    {
        static void Main(string[] args)
        {
            Sum add = (int a, int b) => { Console.WriteLine(a + b); };
            add += (int a, int b) => { Console.WriteLine(a - b); };
            add.Invoke(3, 4);

            List<int> list = new() { 1,5,10,12,15,18,20 };
            List<int> divisibleBy5 = list.FindAll(x => x % 5 == 0);
            foreach (int x in divisibleBy5) {  Console.WriteLine(x); }
        }
    }
}
