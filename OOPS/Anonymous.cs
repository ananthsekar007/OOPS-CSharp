using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    delegate void PrintHello(string message);
    internal class Anonymous
    {
         void Main(string[] args)
        {
            PrintHello hello = delegate(string message) { Console.WriteLine(message); };
            hello("Hi");
        }
    }
}
