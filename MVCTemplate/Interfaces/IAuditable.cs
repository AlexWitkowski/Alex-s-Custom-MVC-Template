﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTemplate.Interfaces
{
    internal interface IAuditable
    {
        DateTime CreatedOn { get; set; }
        string CreatedBy { get; set; }
        DateTime UpdatedOn { get; set; }
        string UpdatedBy { get; set; }
    }
}
