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
        delegate void PrintStuff();
         void Main(string[] args)
        {
            //adddelegate adddelegate = add;
            //adddelegate += subtract;
            //adddelegate(2,4);
            //adddelegate(3,4);
            //delegate[] list = adddelegate.getinvocationlist();
            //foreach (delegate d in list)
            //{
            //    console.writeline(d.dynamicinvoke(1, 1));
            //}

            PrintStuff printStuff = HelloWorld;
            printStuff.Invoke();

            Action<string> action = (name) => {Console.WriteLine(name);};
            action.Invoke("Ananth");
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
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
