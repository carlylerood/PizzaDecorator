using PizzaDecorator.Component;

namespace PizzaDecorator.ConcreteComponent
{
    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            Description = "Large pizza";
        }

        public override double GetCost()
        {
            return 8.00;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
