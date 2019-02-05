using PizzaDecorator.ConcreteComponent;
using Xunit;

namespace PizzaDecoratorTests
{
    public class PizzaTests
    {
        [Fact]
        public void GetDescription_SmallPizza_ReturnsBaseDescription()
        {
            var pizza = new SmallPizza();
            var result = pizza.GetDescription();
            Assert.Equal("Small pizza", result);
        }

        [Fact]
        public void GetCost_SmallPizza_ReturnsBasePrice()
        {
            var pizza = new SmallPizza();
            var result = pizza.GetCost();
            Assert.Equal(6.00, result);
        }
    }
}
