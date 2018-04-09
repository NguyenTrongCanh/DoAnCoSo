using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [ForeignKey("OrderID")]
        public int OrderID { set; get; }

        public virtual Order Order { set; get; }

        [ForeignKey("ProductID")]
        public int ProductID { set; get; }

        public virtual MovieCategory MovieCategory { set; get; }
        public int Quantily { set; get; }
    }
}