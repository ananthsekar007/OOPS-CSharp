using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Food
    {
        static Dictionary<string, int> foods = new()
        {
            ["banana"] = 100,
            ["egg"] = 40,
        };

        public static int GetCalorie(string foodName)
        {
            return foods[foodName];
        }
    }
}
