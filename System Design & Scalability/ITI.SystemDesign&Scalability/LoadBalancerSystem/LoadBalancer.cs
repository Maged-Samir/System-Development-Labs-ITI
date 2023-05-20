using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadBalancerSystem
{
    public class LoadBalancer
    {
        private List<string> servers;
        private int currentIndex;

        public LoadBalancer(List<string> serverUrls)
        {
            servers = serverUrls;
            currentIndex = 0;
        }

        public string GetNextServerUrl()
        {
            lock (servers)
            {
                if (currentIndex >= servers.Count)
                    currentIndex = 0;

                string serverUrl = servers[currentIndex];
                currentIndex++;

                return serverUrl;
            }
        }
    }
}
