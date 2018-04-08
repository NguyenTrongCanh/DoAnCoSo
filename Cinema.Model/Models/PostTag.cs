using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        public int PostID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }

        public string TagID { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}