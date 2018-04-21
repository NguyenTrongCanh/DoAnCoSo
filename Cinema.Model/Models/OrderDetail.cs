using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int OrderID { set; get; }

        [Column(Order = 2)]
        [Key]
        public int MovieID { set; get; } 

        public int FoodID { set; get; }

        [ForeignKey("MovieID")]
        public virtual Movie Movie { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }
         
        [ForeignKey("FoodID")]
        public virtual Food Food { set; get; }

        public int Quantity { set; get; }
    }
}