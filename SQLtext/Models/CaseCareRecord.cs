using System;
using System.Collections.Generic;

#nullable disable

namespace SQLtext.Models
{
    public partial class CaseCareRecord
    {
        public string CaseQaid { get; set; }
        public string CaseNo { get; set; }
        public DateTime CaseTime1 { get; set; }
        public DateTime CaseTime2 { get; set; }
        public string CaseCont { get; set; }
        public string CaseIssue { get; set; }
        public string CaseRem { get; set; }
        public string MemSid { get; set; }
        public DateTime CaseRegTime { get; set; }

        public virtual CaseInfor CaseNoNavigation { get; set; }
        public virtual MemberInformation MemS { get; set; }
    }
}
