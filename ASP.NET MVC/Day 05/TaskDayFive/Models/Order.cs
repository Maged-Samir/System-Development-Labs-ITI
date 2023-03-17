using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TaskDayFive.Helper;

namespace TaskDayFive.Models
{

    [Table("OrderInfo")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }



        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime OrderDate { get; set; }

        [MinPrice(20)]
        public int TotalPrice { get; set; }

        
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}