
namespace Decorator
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n With Extra Cheese.";
            return type;
        }
    }
}
