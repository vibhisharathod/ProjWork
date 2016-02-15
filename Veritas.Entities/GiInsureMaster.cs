using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veritas.Entities
{
    [Table("GI_InsureMaster")]
    public class GiInsureMaster
    {
        [Key]
        [Required]
        public int GIMastIndex { get; set; } // int, not null
        [Required]
        public int ClientIndex { get; set; } // int, not null
        [Required]
        public int AgencyIndex { get; set; } // int, not null
        public int? SubBrokerIndex { get; set; } // int, null
        public int? GICompanyIndex { get; set; } // int, null
        public int? GITypeIndex { get; set; } // int, null
        public int? GroupIndex { get; set; } // int, null
        [MaxLength(50)]
        public string PolicyNo { get; set; } // varchar(50), null
        [Required]
        public int GIProductIndex { get; set; } // int, not null
        public DateTime? LoginDate { get; set; } // datetime, null
        public DateTime? PolicyStartDate { get; set; } // datetime, null
        public DateTime? PolicyExpiryDate { get; set; } // datetime, null
        public decimal? PremiumAmt { get; set; } // decimal(15,2), null
        public decimal? SAAmt { get; set; } // decimal(15,2), null
        [MaxLength(50)]
        public string GISubType { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Model { get; set; } // varchar(50), null
        [MaxLength(25)]
        public string RegNo { get; set; } // varchar(25), null
        [MaxLength(25)]
        public string EngineNumber { get; set; } // varchar(25), null
        [MaxLength(50)]
        public string ChasisNo { get; set; } // varchar(50), null
        [MaxLength(25)]
        public string CubicCapacity { get; set; } // varchar(25), null
        [MaxLength(10)]
        public string ManuYear { get; set; } // nchar(10), null
        [MaxLength(25)]
        public string VehicleColor { get; set; } // varchar(25), null
        [MaxLength(50)]
        public string RegistrationPlace { get; set; } // varchar(50), null
        public DateTime? RegDATE { get; set; } // datetime, null
        [MaxLength(25)]
        public string SeatingCapacity { get; set; } // varchar(25), null
        [MaxLength(25)]
        public string FuelType { get; set; } // varchar(25), null
        public decimal? PresentIDV { get; set; } // decimal(18,2), null
        public decimal? BasicPremium { get; set; } // decimal(18,2), null
        public decimal? LoadingAmt { get; set; } // decimal(18,2), null
        public decimal? PremiumAfterLoading { get; set; } // decimal(18,2), null
        public decimal? Discount { get; set; } // decimal(18,2), null
        public decimal? NoClaimBonus { get; set; } // decimal(18,2), null
        public decimal? ServiceTax { get; set; } // decimal(18,2), null
        public decimal? EduCess { get; set; } // decimal(18,2), null
        [MaxLength(50)]
        public string DepositType { get; set; } // nchar(50), null
        [MaxLength(100)]
        public string BankName { get; set; } // varchar(100), null
        [MaxLength(50)]
        public string ChequeNo { get; set; } // varchar(50), null
        public DateTime? ChequeDate { get; set; } // datetime, null
        public bool? Cancelled { get; set; } // bit, null
        [MaxLength(1000)]
        public string CancelledReason { get; set; } // varchar(1000), null
        [MaxLength(10)]
        public string PolicyStatus { get; set; } // nchar(10), null
        public decimal? ThirdPartyPrem { get; set; } // decimal(18,2), null
        public decimal? PAtoUnnamed { get; set; } // decimal(18,2), null
        public decimal? PAtoCarOwner { get; set; } // decimal(18,2), null
        [MaxLength(2000)]
        public string Remarks { get; set; } // varchar(2000), null
        public int? CreateUserIndex { get; set; } // int, null
        public int? UpdateUserIndex { get; set; } // int, null
        public DateTime? CreateDateTime { get; set; } // datetime, null
        public DateTime? UpdateDateTime { get; set; } // datetime, null
        [MaxLength(50)]
        public string ClaimProcess { get; set; } // varchar(50), null
        [MaxLength(250)]
        public string TPANAME { get; set; } // varchar(250), null
        [MaxLength(1000)]
        public string OldPolicyNo { get; set; } // varchar(1000), null
        [MaxLength(50)]
        public string Status { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string ApplicationNo { get; set; } // varchar(50), null
        public bool? SendToCompany { get; set; } // bit, null
        public bool? ReceivedDocument { get; set; } // bit, null
        [MaxLength(15)]
        public string DispatchMethod { get; set; } // varchar(15), null
        public bool? DispatchStatus { get; set; } // bit, null
        public bool? Dispatch { get; set; } // bit, null
        public double? BrokerageAmt { get; set; } // float, null
        public decimal? DiscountPer { get; set; } // decimal(18,2), null
        public decimal? NCBPer { get; set; } // decimal(18,2), null
        public decimal? AddOnCover { get; set; } // decimal(18,2), null
        public double? TerrisiomPremium { get; set; } // float, null
        public int? HPAIndex { get; set; } // int, null
        [MaxLength(150)]
        public string BranchName { get; set; } // varchar(150), null
        public decimal? MarineSA { get; set; } // decimal(18,2), null
        public decimal? RemainingMarineSA { get; set; } // decimal(18,2), null
        public decimal? StampDuty { get; set; } // decimal(18,2), null
        public decimal? ChequeAmt { get; set; } // decimal(18,2), null
        public decimal? Premiumbeforetax { get; set; } // decimal(18,2), null
        public DateTime? PolicyEndDate { get; set; } // datetime, null
        public decimal? CashAmt { get; set; } // decimal(12,2), null
        public DateTime? PDate { get; set; } // datetime, null
        public bool? PAYesNo { get; set; } // bit, null
        public decimal? Return_Amt { get; set; } // decimal(12,2), null
        public decimal? CostPremium { get; set; } // decimal(12,2), null
        public decimal? CostPremiumPA { get; set; } // decimal(12,2), null
        public decimal? ST_P { get; set; } // decimal(12,2), null
        public decimal? Net_Pay { get; set; } // decimal(12,2), null
        public decimal? PAPremium { get; set; } // decimal(12,2), null
        public decimal? Policy_NoPA { get; set; } // decimal(12,2), null
        public int? TM_Code { get; set; } // int, null
        public int? SE_Code { get; set; } // int, null
        public int? MA_Code { get; set; } // int, null
        public DateTime? RecdDate { get; set; } // datetime, null
        public bool? RecdCust { get; set; } // bit, null
        public DateTime? PolicySince { get; set; } // datetime, null
        public DateTime? ren_dispatchdate { get; set; } // datetime, null
        [MaxLength(50)]
        public string ren_mode_of_dispatch { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string ren_dispatchedby { get; set; } // varchar(50), null
        [MaxLength(150)]
        public string ren_disprmk { get; set; } // varchar(150), null
        public bool? Ren_Generated { get; set; } // bit, null
        public DateTime? CancelledDate { get; set; } // datetime, null
        [MaxLength(50)]
        public string planCode { get; set; } // varchar(50), null
        public decimal? TotalA { get; set; } // decimal(12,2), null
        public decimal? TotalB { get; set; } // decimal(12,2), null
        public bool? IsDeleted { get; set; } // bit, null
        public decimal? GLoadPerc { get; set; } // decimal(12,2), null
        public DateTime? Ren_Rec_Date { get; set; } // datetime, null
        public DateTime? PODDate { get; set; } // datetime, null
        public DateTime? Bulk_Dis_Date { get; set; } // datetime, null
        public DateTime? DispatchDate { get; set; } // datetime, null
        public DateTime? Ren_PodDate { get; set; } // datetime, null
        [MaxLength(10)]
        public string Mode_of_Dispatch { get; set; } // nchar(10), null
        [MaxLength(50)]
        public string CourierName { get; set; } // varchar(50), null
        public decimal? EarthQueckAmt { get; set; } // decimal(12,2), null
        public decimal? BasicA { get; set; } // decimal(12,2), null
        [MaxLength(150)]
        public string Bulk_Dis_Courier_Name { get; set; } // varchar(150), null
        public bool? PolicyStatusFlag { get; set; } // bit, null
        public decimal? CashVISPL { get; set; } // decimal(12,2), null
        public decimal? ChqVISPL { get; set; } // decimal(12,2), null
        public decimal? RetVISPL { get; set; } // decimal(12,2), null
        public decimal? CashINS { get; set; } // decimal(12,2), null
        public decimal? ChqINS { get; set; } // decimal(12,2), null
        public decimal? RetINS { get; set; } // decimal(12,2), null
        [MaxLength(50)]
        public string AccNo { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string OldAccNo { get; set; } // varchar(50), null
    }
}
