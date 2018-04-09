using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("MovieCategorys")]
  public class MovieCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự động tăng
        public int ID { set; get; }
        [Required]
        public string NameMovie { set; get; } 
        [Required]
        public string Alias { set; get; }//Bí danh  
        public string Desciption { set; get; }//Miêu tả
        public int? DisplayOrder { set; get; }
        public string Image { set; get; }//Hình

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Movie> Moives { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }


    }
}