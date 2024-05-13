using System;
using System.Collections.Generic;

namespace Singleton
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public sealed class LoadBalancer
    {
        // Note: constructor is 'private'
        private LoadBalancer()
        {
            servers = new List<Server>
                {
                  new Server{ Name = "ServerI", IP = "120.14.220.18" },
                  new Server{ Name = "ServerII", IP = "120.14.220.19" },
                  new Server{ Name = "ServerIII", IP = "120.14.220.20" },
                  new Server{ Name = "ServerIV", IP = "120.14.220.21" },
                  new Server{ Name = "ServerV", IP = "120.14.220.22" },
                };
        }

        //Note: System.Lazy<T> available For .NET 4 (or higher) 
        //Note: The code above implicitly uses LazyThreadSafetyMode.ExecutionAndPublication as the thread safety mode for the Lazy<LoadBalancer>.
        private static readonly Lazy<LoadBalancer> Lazy = new Lazy<LoadBalancer>(() => new LoadBalancer());
        public static LoadBalancer Instance { get { return Lazy.Value; } }


        private readonly List<Server> servers;
        private readonly Random random = new Random();

        public Server NextServer
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r];
            }
        }
    }

    /// <summary>
    /// Represents the server 
    /// </summary>
    public class Server
    {
        public string Name { get; set; }
        public string IP { get; set; }
    }
}

