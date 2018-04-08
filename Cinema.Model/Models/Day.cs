using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model.Models
{
    [Table("Days")]
    public class Day
    {

        public DateTime Date { set; get; }
        [ForeignKey("NameMovie")]
        public string NameMovie { set; get; }
        public virtual Movie Movie { set; get; }
        [ForeignKey("NameTheater")]
        public string NameTheater { set; get; }

    }
}
