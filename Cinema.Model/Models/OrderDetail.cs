using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }
        [Key]
        public int ProductID { set; get; }

        [ForeignKey("ProductID")]
        public virtual MovieCategory MovieCategory { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }

        public int Quantily { set; get; }
    }
}