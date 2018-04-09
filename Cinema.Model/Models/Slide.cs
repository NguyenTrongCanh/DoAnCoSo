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
        [MaxLength(256)]
        public string Name { set; get; }
        [MaxLength(256)]
        public string Decription { set; get; }

        [Required]
        [MaxLength(256)]
        public string Image { set; get; }

        [Required]
        [MaxLength(256)] 
        public string URL { set; get; }

        public int? DisplayOrder { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}