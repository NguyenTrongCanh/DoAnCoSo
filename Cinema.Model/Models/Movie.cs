using Cinema.Model.Abstract;
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

        public string Day { set; get; }//ID Thời Gian
        //[Required]
        //public string CinemaTheater { set; get; }//Tên rạp

        public string TheaterID { set; get; }//ID rạp

        //[Required]
        //public string TimeMovie { set; get; }//Giờ chiếu

        public string TimeID { set; get; }//ID Thời Gian

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

        [ForeignKey("TimeID")]
        public virtual Time Time { set; get; }

        [ForeignKey("TheaterID")] 
        public virtual Theater Theater { set; get; }
         
        [ForeignKey("DayID")]
        public virtual Day Days { set; get; }
    }
}