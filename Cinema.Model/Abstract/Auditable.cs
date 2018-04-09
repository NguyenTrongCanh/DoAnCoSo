using System;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
        public string CreateBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        [MaxLength(256)]
        public string UpdateBy { set; get; }

        [MaxLength(256)]
        public string MetaKeywork { set; get; }

        [MaxLength(256)]
        public string MetaDesciption { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}