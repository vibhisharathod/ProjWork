using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Veritas.Entities
{
    [Table("MainAgentMaster")]
    public class MainAgentMaster
    {
        [Key]
        [Required]
        public int MainAgent_ID { get; set; } // int, not null
        [MaxLength(150)]
        public string MainAgentName { get; set; } // varchar(150), null
        public int? SE_ID { get; set; } // int, null
        public int? BranchID { get; set; } // int, null
        public int? ASMIndex { get; set; } // int, null
        [MaxLength(20)]
        public string UserName { get; set; } // varchar(20), null
        [MaxLength(20)]
        public string Password { get; set; } // varchar(20), null
        [MaxLength(70)]
        public string House_FlatNo { get; set; } // varchar(70), null
        [MaxLength(70)]
        public string Street { get; set; } // varchar(70), null
        [MaxLength(70)]
        public string Landmark { get; set; } // varchar(70), null
        public int? AreaIndex { get; set; } // int, null
        public int? CityIndex { get; set; } // int, null
        public int? StateIndex { get; set; } // int, null
        public int? Pincode { get; set; } // int, null
        [MaxLength(15)]
        public string MobileNo { get; set; } // varchar(15), null
        [MaxLength(15)]
        public string Cont1 { get; set; } // varchar(15), null
        [MaxLength(15)]
        public string Cont2 { get; set; } // varchar(15), null
        [MaxLength(50)]
        public string Cont_Email { get; set; } // varchar(50), null
        public bool? AllowCommision { get; set; } // bit, null
        public bool? WatchFlag { get; set; } // bit, null
        public bool? LoginStatus { get; set; } // bit, null
        [MaxLength(50)]
        public string Remarks { get; set; } // varchar(50), null
        public bool? Discontinue { get; set; } // bit, null
        public int? CreateUserIndex { get; set; } // int, null
        public DateTime? CreateDateTime { get; set; } // datetime, null
        public int? UpdateUserIndex { get; set; } // int, null
        public DateTime? UpdateDateTime { get; set; } // datetime, null
    }
}
