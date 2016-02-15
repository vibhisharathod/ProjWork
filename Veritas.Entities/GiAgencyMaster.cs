using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veritas.Entities
{
    [Table("GI_AgencyMaster")]
    public class GiAgencyMaster
    {
        [Key]
        [Required]
        public int AgencyIndex { get; set; } // int, not null
        [MaxLength(100)]
        public string AgencyName { get; set; } // varchar(100), null
        [MaxLength(20)]
        public string AgencyCode { get; set; } // varchar(20), null
        public int? CompanyIndex { get; set; } // int, null
        public DateTime? DateOfEnrollment { get; set; } // datetime, null
        public DateTime? DateOfExpiration { get; set; } // datetime, null
        [MaxLength(20)]
        public string PAN_No { get; set; } // varchar(20), null
        [MaxLength(100)]
        public string BankName { get; set; } // varchar(100), null
        [MaxLength(100)]
        public string BranchName { get; set; } // varchar(100), null
        [MaxLength(20)]
        public string AccountType { get; set; } // varchar(20), null
        [MaxLength(15)]
        public string AccountNo { get; set; } // varchar(15), null
        [MaxLength(20)]
        public string MICRCode { get; set; } // varchar(20), null
        [MaxLength(20)]
        public string IFSCCode { get; set; } // varchar(20), null
        [MaxLength(300)]
        public string Address1 { get; set; } // varchar(300), null
        [MaxLength(300)]
        public string Address2 { get; set; } // varchar(300), null
        public int? Pincode { get; set; } // int, null
        public int? CityIndex { get; set; } // int, null
        public int? StateIndex { get; set; } // int, null
        [MaxLength(50)]
        public string Email { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string PhoneNo1 { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string PhoneNo2 { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string MobileNo { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Remarks { get; set; } // varchar(50), null
        public bool? Discontinue { get; set; } // bit, null
        public int? CreateUserIndex { get; set; } // int, null
        public DateTime? CreateDateTime { get; set; } // datetime, null
        public int? UpdateUserIndex { get; set; } // int, null
        public DateTime? UpdateDateTime { get; set; } // datetime, null
    }
}
