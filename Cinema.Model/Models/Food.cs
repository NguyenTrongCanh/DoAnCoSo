using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("Foods")]
    public class Food
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodID { set; get; } 

        [Required]
        [MaxLength(100)]
        public string Name { set; get; }

        [MaxLength(100)]
        public string Images { set; get; }

        [Required]
        public int Price { set; get; }

        [MaxLength(100)]
        public string Decription { set; get; }

        public int InventoryItem { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}