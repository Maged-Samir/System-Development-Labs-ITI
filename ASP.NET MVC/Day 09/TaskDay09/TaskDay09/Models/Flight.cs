using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;

namespace TaskDay09.Models
{
    public enum FlightType { OneWay, TwoWay }

    public class Flight
    {
        public int Id { get; set; }

        public FlightType Type { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime? DateTo { get; set; }
        public int NumberOfSeats { get; set; }
        public Decimal price { get; set; }



        [ForeignKey("Departure")]
        public int DepartureId { get; set; }
        public virtual City Departure { get; set; }




        [ForeignKey("Arrival")]
        public int ArrivalId { get; set; }
        public virtual City Arrival { get; set; }



    }
}
