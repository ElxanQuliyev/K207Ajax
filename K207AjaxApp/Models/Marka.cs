using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K207AjaxApp.Models
{
    public class Marka:BaseEntity
    {
        public virtual List<Model> Models{ get; set; }
    }
}
