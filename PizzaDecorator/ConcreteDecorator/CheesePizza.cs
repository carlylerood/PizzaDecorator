using PizzaDecorator.Component;

namespace PizzaDecorator.ConcreteDecorator
{
    public class CheesePizza : Decorator.PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 1.5;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", cheese";
        }
    }
}
