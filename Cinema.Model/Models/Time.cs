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
        public int TimeID { set; get; } 

        public string Name { set; get; }
        public string StartTime { set; get; }
        public string AmountOfTime { set; get; }
        public virtual IEnumerable<ShowTime> ShowTimes { set; get; }
    }
}