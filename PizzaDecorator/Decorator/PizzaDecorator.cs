using PizzaDecorator.Component;

namespace PizzaDecorator.Decorator
{
    public class PizzaDecorator : Pizza
    {
        private Pizza _pizza;

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override double GetCost()
        {
            return _pizza.GetCost();
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription();
        }
    }
}
