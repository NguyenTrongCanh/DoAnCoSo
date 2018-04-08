using Cinema.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Cinema.Model.Models
{
    [Table("Movies")]
    public class Movie : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự động tăng
        public int ID { set; get; }

        [Required]
        public string NameMovie { set; get; } 

        [Required]
        public string Alias { set; get; }//Bí danh
        
        public int CategoryID { set; get; }//Loại phim
       
        [Required]
        public string CinemaTheater { set; get; }//Tên rạp
        [Required]
        public DateTime Date { set; get; }//Ngày Chiếu
        [Required]
        public string Image { set; get; }//Hình
        public XElement MoreImage { set; get; }//Ảnh liên quan
        [Required]
        public decimal Price { set; get; }//Giá
        public decimal? PromotionPrice { set; get; }//Giá ưu đãi
        [Required]
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
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual MovieCategory MovieCategory { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
        public virtual IEnumerable<Day> Days { set; get; }
    }
}