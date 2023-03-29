using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class BuiltinDelegate
    {

        void Main(string[] args) { 

            //Action Built in type
            Action<string> action = (name) => Console.WriteLine($" Hello, {name}");
            action.Invoke("Ananth");

            //Func Built in type
            Func<int, int,int,  string> func = (a, b, c) => $" The Sum = {a + b + c} ";
            Console.WriteLine(func.Invoke(1,2,3));
                
            //Predicate Built in type
            Predicate<string> predicate = (a) => a.Contains("a") ;
            Console.WriteLine(predicate.Invoke("dumb"));

            List<int> list = new() { 4, 3, 5, 6, 7 };

            Predicate<List<int>> checkifGreaterThanFive = (list) => list.All((a) => a > 5);

            Console.WriteLine(checkifGreaterThanFive.Invoke(list));

        }
    }
}
