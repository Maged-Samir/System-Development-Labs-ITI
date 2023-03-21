namespace TaskDay09.Models
{
    public class City
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Flight> Arriving { get; set; } = new();
        public virtual List<Flight> Departing { get; set; } = new();


    }

    //public class FromCity:City
    //{
    //    public virtual ICollection<Flight> Flights { get; set; } = new HashSet<Flight>();
    //}

    //public class ToCity : City
    //{
    //    public virtual ICollection<Flight> Flights { get; set; } = new HashSet<Flight>();
    //}


}
