using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veritas.Entities
{
    [Table("IN_ClientleMaster")]
    public class InClientleMaster
    {
        [Key]
        [Required]
        public int ClientleIndex { get; set; } // int, not null
        public int? GroupIndex { get; set; } // int, null
        [MaxLength(100)]
        public string Full_NM_LA { get; set; } // varchar(100), null
        [MaxLength(30)]
        public string FatherName { get; set; } // varchar(30), null
        public DateTime? DOB_LA { get; set; } // datetime, null
        [MaxLength(1)]
        public string Gender { get; set; } // char(1), null
        [MaxLength(10)]
        public string Maritial_Status { get; set; } // varchar(10), null
        public DateTime? Anniversary { get; set; } // datetime, null
        [MaxLength(30)]
        public string Nationality { get; set; } // varchar(30), null
        [MaxLength(50)]
        public string Pan_No { get; set; } // varchar(50), null
        [MaxLength(30)]
        public string Place_Birth { get; set; } // varchar(30), null
        [MaxLength(50)]
        public string Comm_House_FlatNo { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Comm_Street { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Comm_Address { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Comm_Landmark { get; set; } // varchar(50), null
        public int? Comm_AreaIndex { get; set; } // int, null
        public int? Comm_CityIndex { get; set; } // int, null
        public int? Comm_PinCode { get; set; } // int, null
        public int? Comm_StateIndex { get; set; } // int, null
        public int? Comm_CountryIndex { get; set; } // int, null
        [MaxLength(15)]
        public string Cont_MobileNo { get; set; } // varchar(15), null
        [MaxLength(15)]
        public string Cont_Home { get; set; } // varchar(15), null
        [MaxLength(15)]
        public string Cont_Fax { get; set; } // varchar(15), null
        [MaxLength(15)]
        public string Cont_Office { get; set; } // varchar(15), null
        [MaxLength(30)]
        public string Cont_Email { get; set; } // varchar(30), null
        [MaxLength(50)]
        public string Res_House_FlatNo { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Res_Street { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Res_Address { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Res_Landmark { get; set; } // varchar(50), null
        public int? Res_AreaIndex { get; set; } // int, null
        public int? Res_CityIndex { get; set; } // int, null
        public int? Res_StateIndex { get; set; } // int, null
        public int? Res_CountryIndex { get; set; } // int, null
        public int? Res_Pincode { get; set; } // int, null
        [MaxLength(30)]
        public string Res_Mobile { get; set; } // nchar(30), null
        [MaxLength(30)]
        public string Res_Phone { get; set; } // nchar(30), null
        [MaxLength(30)]
        public string Res_Email { get; set; } // nchar(30), null
        [MaxLength(30)]
        public string OccupationDetail { get; set; } // varchar(30), null
        [MaxLength(30)]
        public string Designation { get; set; } // varchar(30), null
        public int? EMP_Year { get; set; } // int, null
        public decimal? Yearly_Gross_Income { get; set; } // decimal(15,2), null
        [MaxLength(50)]
        public string BusinessType { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Bus_BldgNameNo { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Bus_Street { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Bus_Address { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Bus_Landmark { get; set; } // varchar(50), null
        public int? Bus_AreaIndex { get; set; } // int, null
        public int? Bus_CityIndex { get; set; } // int, null
        public int? Bus_StateIndex { get; set; } // int, null
        public int? Bus_Pincode { get; set; } // int, null
        public int? Bus_CountryIndex { get; set; } // int, null
        [MaxLength(50)]
        public string Bus_Email { get; set; } // varchar(50), null
        [MaxLength(30)]
        public string Name_Employer { get; set; } // varchar(30), null
        [MaxLength(30)]
        public string Comp_Type { get; set; } // varchar(30), null
        [MaxLength(50)]
        public string Department { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Office_BldgNameNo { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Office_Street { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Office_Address { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Office_Landmark { get; set; } // varchar(50), null
        public int? Office_AreaIndex { get; set; } // int, null
        public int? Office_CityIndex { get; set; } // int, null
        public int? Office_StateIndex { get; set; } // int, null
        public int? Office_Pincode { get; set; } // int, null
        public int? Office_CountryIndex { get; set; } // int, null
        [MaxLength(50)]
        public string Office_Email { get; set; } // varchar(50), null
        [MaxLength(30)]
        public string Relation_With_LA { get; set; } // varchar(30), null
        [MaxLength(30)]
        public string PHONE_R2 { get; set; } // varchar(30), null
        [MaxLength(30)]
        public string PHONE_O2 { get; set; } // varchar(30), null
        [MaxLength(30)]
        public string Mobile2 { get; set; } // varchar(30), null
        [MaxLength(30)]
        public string Co_Mobile1 { get; set; } // varchar(30), null
        [MaxLength(30)]
        public string Co_Phone1 { get; set; } // varchar(30), null
        [MaxLength(30)]
        public string Co_Email1 { get; set; } // varchar(30), null
        public bool? Co_address_Same { get; set; } // bit, null
        public bool? Per_address_Same { get; set; } // bit, null
        public bool? Watch_flag { get; set; } // bit, null
        public int? SE_CODE { get; set; } // int, null
        public int? SA_CODE { get; set; } // int, null
        public int? MA_CODE { get; set; } // int, null
        public bool? Group_Head { get; set; } // bit, null
        public bool? Group_Defined { get; set; } // bit, null
        public int? Client_Match_Index { get; set; } // int, null
        public bool? Client_Match { get; set; } // bit, null
        public bool? Discontinue { get; set; } // bit, null
        public int? CreateUserIndex { get; set; } // int, null
        public DateTime? CreateDateTime { get; set; } // datetime, null
        public int? UpdateUserIndex { get; set; } // int, null
        public DateTime? UpdateDateTime { get; set; } // datetime, null
        [MaxLength(50)]
        public string UserCode { get; set; } // varchar(50), null
        [MaxLength(100)]
        public string Password { get; set; } // varchar(100), null
        public int? Age { get; set; } // int, null
        public int? BranchID { get; set; } // int, null
    }
}
