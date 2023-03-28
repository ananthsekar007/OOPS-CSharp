using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    delegate void AddDelegate(int a, int b);
    internal class Delegates
    {
         void Main(string[] args)
        {
            AddDelegate addDelegate = Add;
            addDelegate += Subtract;
            addDelegate(2,4);
            addDelegate(3,4);
            Delegate[] list = addDelegate.GetInvocationList();
            foreach (Delegate d in list)
            {
                Console.WriteLine(d.DynamicInvoke(1, 1));
            }
        }

        static void Add(int a, int b)
        {
            Console.WriteLine($"Addition - {a + b}");
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine($"Subtraction - {a - b}");
        }
    }
}
