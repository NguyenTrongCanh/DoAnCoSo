using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        public string Decription { set; get; }

        [Required]
        public string Image { set; get; }

        [Required]
        public string URL { set; get; }

        public int DisplayOrder { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}