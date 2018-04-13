using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("Times")]
    public class Time
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string TimeMovie { set; get; }//Time là các giờ, suất chiếu theo ngày.

        public virtual IEnumerable<Movie> Movies { set; get; }
    }
}