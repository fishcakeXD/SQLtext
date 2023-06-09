﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SQLtext.Models
{
    public partial class MemberInformation
    {
        public MemberInformation()
        {
            CarPicks = new HashSet<CarPick>();
            CaseCareRecords = new HashSet<CaseCareRecord>();
            CaseDailyRegistrations = new HashSet<CaseDailyRegistration>();
            CaseTelRecords = new HashSet<CaseTelRecord>();
            LectureTables = new HashSet<LectureTable>();
        }

        public string MemSid { get; set; }
        public string MemUnitName { get; set; }
        public string MemUnitNum { get; set; }
        public string MemName { get; set; }
        public DateTime MemBd { get; set; }
        public string MemUid { get; set; }
        public string MemPassword { get; set; }
        public string MemGender { get; set; }
        public string MemTphone { get; set; }
        public string MemMphone { get; set; }
        public string MemAddress { get; set; }
        public string MemSite { get; set; }
        public string MemProf { get; set; }
        public string MemCert { get; set; }
        public string MemTrans { get; set; }
        public string MemExpr { get; set; }
        public string MemMovt { get; set; }
        public string MemPserv { get; set; }
        public string MemIdent { get; set; }
        public string MemSerRec { get; set; }
        public string MemEdu { get; set; }

        public virtual ICollection<CarPick> CarPicks { get; set; }
        public virtual ICollection<CaseCareRecord> CaseCareRecords { get; set; }
        public virtual ICollection<CaseDailyRegistration> CaseDailyRegistrations { get; set; }
        public virtual ICollection<CaseTelRecord> CaseTelRecords { get; set; }
        public virtual ICollection<LectureTable> LectureTables { get; set; }
    }
}
