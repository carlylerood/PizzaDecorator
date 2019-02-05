using PizzaDecorator.ConcreteComponent;
using System;

namespace PizzaDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizza = new SmallPizza();
            Console.WriteLine("Description: " + pizza.GetDescription());
            Console.WriteLine("Price: $" + pizza.GetCost());
            Console.ReadLine();
        }
    }
}
