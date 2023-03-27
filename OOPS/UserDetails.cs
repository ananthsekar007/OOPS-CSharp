using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPS
{
    internal class UserDetails: Food
    {
        string name;
        int age;
        float height;
        float weight;
        int calorieLimit;

        public UserDetails(string name,  int age, float height, float weight)
        {
            this.name = name;    
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.CalculateCalorieLimit();
        }

        private void CalculateCalorieLimit()
        {
            this.CalorieLimit = Convert.ToInt32(66.5f + 13.8 * this.weight + 5 * this.height / (6.8f * this.age));
        }

        public int CalorieLimit
        {
            get { return this.calorieLimit;}
            set { this.calorieLimit = value; }
        }

        public void EatFood(Food.FoodVarieties foodName)
        {
            this.CalorieLimit -= Food.GetCalorie(foodName);
        }
    }
}
