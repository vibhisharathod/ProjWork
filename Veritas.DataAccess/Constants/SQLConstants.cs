namespace Veritas.DataAccess
{
    public class SQLConstants
    {
        #region InsureMaster
        /// <summary>
        /// Gets All Insure Master table records
        /// </summary>
        public static readonly string GetAllInsureMastersQuery = "SELECT GIMastIndex,ClientIndex,AgencyIndex,SubBrokerIndex,GICompanyIndex,GITypeIndex,GroupIndex,PolicyNo,GIProductIndex,LoginDate,PolicyExpiryDate,PremiumAmt,SAAmt,GISubType,Model,RegNo,EngineNumber,ChasisNo,CubicCapacity,ManuYear,VehicleColor,RegistrationPlace,RegDATE,SeatingCapacity,FuelType,PresentIDV,BasicPremium,LoadingAmt,PremiumAfterLoading,Discount,NoClaimBonus,ServiceTax,EduCess,DepositType,BankName,ChequeNo,ChequeDate,Cancelled,CancelledReason,PolicyStatus,ThirdPartyPrem,PAtoUnnamed,PAtoCarOwner,Remarks,CreateUserIndex,UpdateUserIndex,CreateDateTime,UpdateDateTime,ClaimProcess,TPANAME,OldPolicyNo,Status,ApplicationNo,SendToCompany,ReceivedDocument,DispatchMethod,DispatchStatus,Dispatch,BrokerageAmt,DiscountPer,NCBPer,AddOnCover,TerrisiomPremium,HPAIndex,BranchName,MarineSA,RemainingMarineSA,StampDuty,ChequeAmt,Premiumbeforetax,PolicyEndDate,CashAmt,PDate,PAYesNo,Return_Amt,CostPremium,CostPremiumPA,ST_P,Net_Pay,PAPremium,Policy_NoPA,TM_Code,SE_Code,MA_Code,RecdDate,RecdCust,PolicySince,ren_dispatchdate,ren_mode_of_dispatch,ren_dispatchedby,ren_disprmk,Ren_Generated,CancelledDate,planCode,TotalB,IsDeleted,GLoadPerc,Ren_Rec_Date,PODDate,Bulk_Dis_Date,DispatchDate,Ren_PodDate,Mode_of_Dispatch,CourierName,EarthQueckAmt,BasicA,Bulk_Dis_Courier_Name,PolicyStatusFlag,CashVISPL,ChqVISPL,RetVISPL,CashINS,ChqINS,RetINS From GI_InsureMaster";

        public static readonly string GetInsureMasterViewModelQuery = "SELECT IM.GIMastIndex, IM.PolicyNo,CM.GICompanyName,CliM.Full_NM_LA, IM.LoginDate, IM.PolicyStartDate FROM GI_InsureMaster IM LEFT JOIN GI_CompanyMaster CM ON IM.GICompanyIndex = CM.GICompanyIndex LEFT JOIN IN_ClientleMaster CliM ON IM.ClientIndex = CliM.ClientleIndex";

        #endregion
    }
}
