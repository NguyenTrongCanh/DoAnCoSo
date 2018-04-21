using Cinema.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("Movies")]
    public class Movie : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự động tăng
        public int MovieID { set; get; }

        [Required]
        [MaxLength(256)]
        public string NameMovie { set; get; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }//Bí danh

        public int CategoryID { set; get; }//Loại phim

        // public int ShowTimesID { set; get; }//ID rạp

        [Required]
        [MaxLength(256)]
        public string Image { set; get; }//Hình

        [Column(TypeName = "xml")]
        public string MoreImage { set; get; }//Ảnh liên quan

        [Required]
        public decimal Price { set; get; }//Giá

        public decimal? PromotionPrice { set; get; }//Giá ưu đãi

        [Required]
        [MaxLength(500)]
        public string Desciption { set; get; }//Miêu tả\

        public int? Warranty { set; get; }

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

        public virtual IEnumerable<MovieTag> MovieTags { set; get; }
        public virtual IEnumerable<ShowTime> ShowTimes { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}