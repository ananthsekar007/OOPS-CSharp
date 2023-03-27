using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Food
    {
        public enum FoodVarieties { banana, egg};
        static Dictionary<FoodVarieties, int> foods = new()
        {
            [FoodVarieties.banana] = 100,
            [FoodVarieties.egg] = 40,
        };

        public static int GetCalorie(FoodVarieties foodName)
        {
            return foods[foodName];
        }
    }
}
