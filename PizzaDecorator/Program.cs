using PizzaDecorator.ConcreteComponent;
using PizzaDecorator.ConcreteDecorator;
using System;

namespace PizzaDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizza = new PepperoniPizza(new CheesePizza(new LargePizza()));
            Console.WriteLine("Description: " + pizza.GetDescription());
            Console.WriteLine("Price: $" + pizza.GetCost());
            Console.ReadLine();
        }
    }
}
