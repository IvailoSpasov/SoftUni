using System;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaName = Console.ReadLine().Split();
                string[] doughInfo = Console.ReadLine().Split();
                Dough dough = new Dough(doughInfo[1], doughInfo[2], int.Parse(doughInfo[3]));
                Pizza pizza = new Pizza(pizzaName[1], dough);

                string[] toppingsInfo = Console.ReadLine().Split();

                while (toppingsInfo[0] != "END")
                {
                    string toppingName = toppingsInfo[1];
                    int weight = int.Parse(toppingsInfo[2]);
                    Topping topping = new Topping(toppingName, weight);
                    pizza.AddTopping(topping);
                    toppingsInfo = Console.ReadLine().Split();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
