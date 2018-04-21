using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("ShowTimes")]
    public class ShowTime
    {
        [Key]
        public int ID { set; get; }

        public DateTime StartDay { set; get; }
        public DateTime EndDay { set; get; }
        public int MovieID { set; get; }
        public int TheaterID { set; get; }
        public int TimeID { set; get; }

        [ForeignKey("MovieID")]
        public virtual Movie Movie { set; get; }

        [ForeignKey("TheaterID")]
        public virtual Theater Theater { set; get; }

        [ForeignKey("TimeID")]
        public virtual Time Time { set; get; }
    }
}