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

        [ForeignKey("DayID")]
        public int DayID { set; get; }// ID ngày cho danh sách ngày lấy từ bảng Days

        public virtual Day Day { set; get; }

        //[Required]
        //public int MovieID { set; get; }

        //[ForeignKey("TheaterID")]
        //public int TheaterID { set; get; }
        //public virtual Theater Theater { set; get; }

        public virtual IEnumerable<Movie> Movies { set; get; }
    }
}