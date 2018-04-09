using Cinema.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string CustomerName { set; get; }

        [Required]
        public string CustomerAddress { set; get; }

        [Required]
        public string CustomerEmail { set; get; }

        [Required]
        public string CustomerPhone { set; get; }

        public string CustomerMessage { set; get; }

        public string PaymenMethod { set; get; }

        [Required]
        public string PaymentStatus { set; get; }

        //public string Status { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}