using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("MovieCategories")]
    public class MovieCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự động tăng
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string NameMovie { set; get; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }//Bí danh

        [MaxLength(500)]
        public string Desciption { set; get; }//Miêu tả

        public int? DisplayOrder { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }//Hình

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Movie> Moives { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}