using System;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        // Private constructor to prevent instantiation
        private Singleton()
        {
        }

        // Method to get the singleton instance
        public static Singleton GetInstance()
        {
            // If the instance is not yet created, create it
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // Example method of the Singleton class
        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is doing something.");
        }
    }
}
