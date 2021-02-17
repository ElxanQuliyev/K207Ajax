using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K207AjaxApp.Models
{
    public class Model:BaseEntity
    {
        public int MarkaID { get; set; }
        public virtual Marka Marka { get; set; }
    }
}
