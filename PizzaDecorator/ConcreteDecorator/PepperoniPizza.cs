using PizzaDecorator.Component;

namespace PizzaDecorator.ConcreteDecorator
{
    public class PepperoniPizza : Decorator.PizzaDecorator
    {
        public PepperoniPizza(Pizza pizza) : base(pizza)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.75;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", pepperoni";
        }
    }
}
