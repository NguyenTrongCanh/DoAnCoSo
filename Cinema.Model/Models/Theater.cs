using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("Theater")]
    public class Theater
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TheaterID { set; get; }

        [Required]
        public string NameTheater { set; get; } 

       
        public virtual IEnumerable<ShowTime> ShowTimes { set; get; }
    }
}