using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskDay09.Models
{

    [Table("TrackInfo")]
    public class Track
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Please Enter Your Track Name")]
        [Display(Name = "Track")]
        [MaxLength(20,ErrorMessage ="Please Note that Max lenth for this field 20 chars")]
        public string Name { get; set; }



        [Required]
        [MaxLength(200, ErrorMessage = "Please Note that Max lenth for this field 200 chars")]
        public string Description { get; set; }


        public virtual List<Trainee> Trainees { get; set; }= new List<Trainee>();
    }
}
