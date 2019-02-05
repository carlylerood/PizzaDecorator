using PizzaDecorator.ConcreteComponent;
using PizzaDecorator.ConcreteDecorator;
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

        [Fact]
        public void GetCost_CheesePizza_ReturnsBasePricePlusCheesePrice()
        {
            var pizza = new CheesePizza(new SmallPizza());
            var result = pizza.GetCost();
            Assert.Equal(7.50, result);
        }

        [Fact]
        public void GetDescription_CheesePizza_ReturnsBaseDescriptionPlusCheeseDescription()
        {
            var pizza = new CheesePizza(new SmallPizza());
            var result = pizza.GetDescription();
            Assert.Equal("Small pizza, cheese", result);
        }

        [Fact]
        public void GetCost_PepperoniPizzaWithCheese_ReturnsDescription()
        {
            var pizza = new PepperoniPizza(new CheesePizza(new SmallPizza()));
            var result = pizza.GetCost();
            Assert.Equal(8.25, result);
        }

        [Fact]
        public void GetDescription_PepperoniPizzaWithCheese_ReturnsDescription()
        {
            var pizza = new PepperoniPizza(new CheesePizza(new SmallPizza()));
            var result = pizza.GetDescription();
            Assert.Equal("Small pizza, cheese, pepperoni", result);
        }

        [Fact]
        public void GetCost_LargePepperoniPizzaWithCheese_ReturnsCost()
        {
            var pizza = new PepperoniPizza(new CheesePizza(new LargePizza()));
            var result = pizza.GetCost();
            Assert.Equal(10.25, result);
        }
    }
}
