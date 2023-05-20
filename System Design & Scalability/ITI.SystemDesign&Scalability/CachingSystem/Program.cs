using CachingSystem.Data;

namespace CachingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CacheManager cacheManager = new CacheManager();

            // Example usage
            List<Employee> cachedData = cacheManager.GetOrSet("myKey", () =>
            {
                Console.WriteLine("Fetching data...");
                return GetDataFromDatabase(); // Replace with your data retrieval logic
            }, TimeSpan.FromSeconds(10));

            // Retrieve and print employee data
            Console.WriteLine("Fetching Caching data...");
            foreach (var employee in cachedData)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
            }

            Console.ReadLine();
        }

        static List<Employee> GetDataFromDatabase()
        {
            Console.WriteLine("Fetching data from database...");
            // Add employees to the database
            Employee.Employees.Add(new Employee { Id = 1, Name = "John Doe", Department = "IT", Salary = 5000 });
            Employee.Employees.Add(new Employee { Id = 2, Name = "Jane Smith", Department = "HR", Salary = 4000 });
            Employee.Employees.Add(new Employee { Id = 3, Name = "Mike Johnson", Department = "Finance", Salary = 6000 });


            // Retrieve and print employee data
            foreach (var employee in Employee.Employees)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
            }

            Console.WriteLine("-----------------------------------------");

            //return "Data from database";
            return Employee.Employees;

        }

    }
}
