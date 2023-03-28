using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public delegate int AddDelegate(int a, int b);
    internal class Delegate
    {
        static void Main(string[] args)
        {
            AddDelegate addDelegate = Add;
            Console.WriteLine(addDelegate.Invoke(2,4));
            Console.WriteLine(Add(2,3));
            Console.WriteLine(addDelegate(3,4));
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
