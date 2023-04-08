using APIs.Day1.Validators;

namespace Day01.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; } = string.Empty;
        public double Price { get; set; }

        [DateInPast]
        public DateTime ProductionDate { get; set; }

        public string Type { get; set; } = string.Empty; 

        public Car(int id,string model, double price, DateTime productionDate)
        {
            Id = id;
            Model = model;
            Price = price;
            ProductionDate = productionDate;
        }

        public static List<Car> Cars = new()
    {
        new (1, "Nubira", 90_000,DateTime.Parse("1980-01-01")),
        new (2, "Kia",  100_000, DateTime.Parse("2000-01-01") ),
        new (3, "Hundia",200_000, DateTime.Parse("2006-01-01")),
        new (4, "Tesla",  500_000,DateTime.Parse("2015-01-01")),
    };
    }
}
