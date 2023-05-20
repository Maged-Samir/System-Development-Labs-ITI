namespace LoadBalancerSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of server URLs
            List<string> serverUrls = new List<string>
        {
            "http://server1.example.com",
            "http://server2.example.com",
            "http://server3.example.com"
        };

            // Create an instance of the load balancer
            LoadBalancer loadBalancer = new LoadBalancer(serverUrls);

            // Make requests to the load balancer
            for (int i = 0; i < 10; i++)
            {
                string serverUrl = loadBalancer.GetNextServerUrl();
                Console.WriteLine($"Request {i + 1}: {serverUrl}");
            }

            Console.ReadLine();
        }
    }
}