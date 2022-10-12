
namespace Decorator
{
    public class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override  string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n With Extra Onions.";
            return type;
        }
    }
}
