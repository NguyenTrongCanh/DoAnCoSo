using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự động tăng
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Alias { set; get; }//Bí danh

        [MaxLength(500)]
        public string Desciption { set; get; }//Miêu tả

        public int? DisplayOrder { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }//Hình

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Post> Posts { set; get; }
    }
}