﻿using Cinema.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("Menus")]
    public class Menu : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự động tăng
        public int MenuID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string URL { set; get; }

        public int? DisplayOrder { set; get; }

        [Required]
        public int GroupID { set; get; }

        //ForeignKey trỏ đến MenuGroup.
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }
        [MaxLength(10)]
        public string Target { set; get; }

        //[Required]
        //public bool Status { set; get; }
    }
}