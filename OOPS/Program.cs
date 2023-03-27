namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the User Details \n \n");
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Height : ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Weight : ");
            int weight = Convert.ToInt32(Console.ReadLine());
            UserDetails userDetails = new UserDetails(name, age, height, weight);
            
            while(true)
            {
            Console.WriteLine("Start Eating food, once you want to stop , enter \"stop\" or else enter \"continue\" ");
                if(Console.ReadLine() == "stop")
                {
                    break;
                }
                else
                {
                    Console.Write("What are you eating? : ");
                    Food.FoodVarieties food = (Food.FoodVarieties) Enum.Parse(typeof(Food.FoodVarieties),Console.ReadLine());
                    userDetails.EatFood(food);
                }
            }
            Console.WriteLine($" \n\n The remaining calories for the day is {userDetails.CalorieLimit} ");
        }
    }
}