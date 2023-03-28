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
        }
    }
}
