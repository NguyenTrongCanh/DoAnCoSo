﻿using Cinema.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Cinema.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự động tăng
        public int PostID { set; get; }
         
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }//Bí danh

        public int CategoryID { set; get; }//Loại phim

        [Required]
        [MaxLength(256)]
        public string Image { set; get; }//Hình

        [Column(TypeName ="xml")]
        public string MoreImage { set; get; }//Ảnh liên quan

        public decimal? PromotionPrice { set; get; }//Giá ưu đãi

        [Required]
        [MaxLength(500)]
        public string Desciption { set; get; }//Miêu tả

        [Required]
        public string Content { set; get; }//Nội dung

        [Required]
        public string Actor { set; get; }//Diễn Viên

        [Required]
        public string Directors { set; get; }//Đạo diễn

        [Required]
        public string Producer { set; get; }//Nhà sản xuất

        [Required]
        public string Age { set; get; }//Lứa tuổi

        public bool? HomeFlag { set; get; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }

        public virtual IEnumerable<PostTag> PostTags { set; get; }
    }
}