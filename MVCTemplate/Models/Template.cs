using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTemplate.Models
{
    //TODO DELETE OR REPLACE Template Model
    public class Template : Auditable
    {
        public int Id { get; set; }
        public string Temp { get; set; }
    }
}
