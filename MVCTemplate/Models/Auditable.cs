using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCTemplate.Interfaces;

namespace MVCTemplate.Models
{
    public abstract class Auditable : IAuditable
    {
        [ScaffoldColumn(false)]
        public DateTime CreatedOn { get; set; }

        [ScaffoldColumn(false)]
        [StringLength(256)]
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdatedOn { get; set; }

        [ScaffoldColumn(false)]
        [StringLength(256)]
        public string UpdatedBy { get; set; }

        [Timestamp]
        public Byte[] RowVersion { get; set; }
    }
}
