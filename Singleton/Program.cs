using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleOne();

            ExampleTwo();

            Console.ReadLine();
        }

        private static void ExampleOne()
        {
            // Get the singleton instance
            Singleton singleton = Singleton.GetInstance();

            // Call a method of the singleton instance
            singleton.DoSomething();

            // Try to create another instance (which should return the existing instance)
            Singleton anotherSingleton = Singleton.GetInstance();

            // Check if both instances are the same
            Console.WriteLine("Are both instances the same? " + (singleton == anotherSingleton));
        }

        private static void ExampleTwo()
        {
            var obj1 = LoadBalancer.Instance;
            var obj2 = LoadBalancer.Instance;
            var obj3 = LoadBalancer.Instance;
            var obj4 = LoadBalancer.Instance;

            // Confirm these are the same instance
            if (obj1 == obj2 && obj2 == obj3 && obj3 == obj4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Next, load balance 15 requests for a server
            var balancer = LoadBalancer.Instance;
            for (int i = 0; i < 15; i++)
            {
                string serverName = balancer.NextServer.Name;
                Console.WriteLine("Dispatch request to: " + serverName);
            }
        }
    }
}
