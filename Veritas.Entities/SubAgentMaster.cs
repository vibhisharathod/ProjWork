using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veritas.Entities
{
    [Table("SubAgentMaster")]
    public class SubAgentMaster
    {
        [Key]
        [Required]
        public int SubAgent_ID { get; set; } // int, not null
        [MaxLength(150)]
        public string SubAgentName { get; set; } // varchar(150), null
        public int? MA_ID { get; set; } // int, null
        public int? SE_ID { get; set; } // int, null
        public int? Branch_ID { get; set; } // int, null
        public int? AgentTypeID { get; set; } // int, null
        [MaxLength(20)]
        public string UserName { get; set; } // varchar(20), null
        [MaxLength(20)]
        public string Password { get; set; } // varchar(20), null
        [MaxLength(70)]
        public string Res_House_FlatNo { get; set; } // varchar(70), null
        [MaxLength(70)]
        public string Res_Street { get; set; } // varchar(70), null
        [MaxLength(70)]
        public string Res_Landmark { get; set; } // varchar(70), null
        public int? AreaIndex { get; set; } // int, null
        public int? CityIndex { get; set; } // int, null
        public int? StateIndex { get; set; } // int, null
        public int? Res_Pincode { get; set; } // int, null
        [MaxLength(15)]
        public string Cont_MobileNo { get; set; } // varchar(15), null
        [MaxLength(15)]
        public string Cont1 { get; set; } // varchar(15), null
        [MaxLength(15)]
        public string Cont2 { get; set; } // varchar(15), null
        [MaxLength(50)]
        public string Cont_Email { get; set; } // varchar(50), null
        [MaxLength(10)]
        public string PANNo { get; set; } // nchar(10), null
        public DateTime? StartYear { get; set; } // datetime, null
        [MaxLength(25)]
        public string BankAccountNo { get; set; } // varchar(25), null
        [MaxLength(25)]
        public string BankIFSCNo { get; set; } // varchar(25), null
        public bool? LoginStatus { get; set; } // bit, null
        [MaxLength(50)]
        public string Remarks { get; set; } // varchar(50), null
        public bool? Discontinue { get; set; } // bit, null
        public int? CreateUserIndex { get; set; } // int, null
        public DateTime? CreateDateTime { get; set; } // datetime, null
        public int? UpdateUserIndex { get; set; } // int, null
        public DateTime? UpdateDateTime { get; set; } // datetime, null
        [MaxLength(150)]
        public string BankName { get; set; } // varchar(150), null

        //FK
        public string CityName { get; set; }
        public string StateName { get; set; }
    }
}
