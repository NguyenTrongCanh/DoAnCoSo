using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("PostCategorys")]
    public class PostCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự động tăng
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Alias { set; get; }//Bí danh

        public string Desciption { set; get; }//Miêu tả
        public int? DisplayOrder { set; get; }
        public string Image { set; get; }//Hình

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Post> Posts { set; get; }
    }
}