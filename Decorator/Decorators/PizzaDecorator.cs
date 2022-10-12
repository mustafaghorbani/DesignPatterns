
namespace Decorator
{
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            this._pizza = pizza;
        }

        public virtual string GetPizzaType()
        {
             return _pizza.GetPizzaType();
        }
    }
}
