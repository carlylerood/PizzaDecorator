using PizzaDecorator.Component;

namespace PizzaDecorator.ConcreteComponent
{
    public class SmallPizza : Pizza
    {
        public SmallPizza()
        {
            Description = "Small pizza";
        }

        public override double GetCost()
        {
            return 6.00;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
