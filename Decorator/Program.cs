using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            IPizza pizza = new Pizza();
            IPizza CheeseDecorator = new CheeseDecorator(pizza);
            IPizza TomatoDecorator = new TomatoDecorator(CheeseDecorator);
            IPizza OnionDecorator = new OnionDecorator(TomatoDecorator);

            Console.WriteLine(OnionDecorator.GetPizzaType());


            Console.ReadLine();
        }
    }
}
