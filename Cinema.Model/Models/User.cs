using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Model.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Account { set; get; }

        [Required]
        public string PassWord { set; get; }

        [Required]
        public int Role { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Address { set; get; }

        [Required]
        public string Phone { set; get; }

        [Required]
        public string Email { set; get; }

        [Required]
        public DateTime BirthDay { set; get; }

        [Required]
        public string Job { set; get; }
    }
}