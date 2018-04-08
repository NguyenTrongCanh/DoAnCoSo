using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model.Abstract
{
   public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
     
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }

        string MetaKeywork { set; get; }
        string MetaDesciption { set; get; }
        bool Status { set; get; }
            
    }
}
