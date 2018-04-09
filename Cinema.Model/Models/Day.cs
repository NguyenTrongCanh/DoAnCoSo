using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("Days")]
    public class Day
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Date { set; get; }

        public virtual IEnumerable<Time> Times { set; get; }
        public virtual IEnumerable<Movie> Movies { set; get; }
    }
}