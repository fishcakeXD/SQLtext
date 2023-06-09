﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SQLtext.Models
{
    public partial class CaseAct
    {
        public string ActId { get; set; }
        public DateTime ActDate { get; set; }
        public string ActLec { get; set; }
        public string ActCourse { get; set; }
        public string ActLoc { get; set; }
        public string CaseNo { get; set; }
        public string ActSer { get; set; }

        public virtual CaseInfor CaseNoNavigation { get; set; }
    }
}
