using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("MovieTags")]
    public class MovieTag
    {
        [Key]
        public int MovieID { set; get; }

        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string TagID { set; get; }

        [ForeignKey("MovieID")]
        public virtual Movie Movie { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}