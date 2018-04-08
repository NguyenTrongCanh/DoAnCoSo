using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        public int ProductID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Movie Movie { set; get; }

        public string TagID { set; get; } 

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}