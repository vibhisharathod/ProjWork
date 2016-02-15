using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
    public class InsureMasterDA : BaseRepository, IInsureMasterDA
    {
        public Task<GiInsureMaster> Find(int? id)
        {
            throw new NotImplementedException();
        }

        //IDbConnection Veritasdb = new SqlConnection(ConfigurationManager.AppSettings["Veritas"].ToString());
        //public GiInsureMaster Add(GiInsureMaster Branch)
        //{
        //    int index = 0;
        //    string query = "SELECT max(GIMastIndex) FROM GI_InsureMaster";
        //    var id = CreateContext().Query<string>(query).Single();
        //    if (id == null || id == "0")
        //    {
        //        index = 1;
        //    }
        //    else
        //    {
        //        index = Convert.ToInt32(id) + 1;
        //    }
        //    int createindex = 1;
        //    string accno = DateTime.Now.ToShortDateString() + index;
        //    var sqlQuery = "INSERT INTO GI_InsureMaster (GIMastIndex,AccNo,ClientIndex,AgencyIndex,SubBrokerIndex,GICompanyIndex,GITypeIndex,GroupIndex,PolicyNo,GIProductIndex,LoginDate,PolicyStartDate,PolicyExpiryDate,PremiumAmt,SAAmt,GISubType,Model,RegNo,EngineNumber,ChasisNo,CubicCapacity,ManuYear,VehicleColor,RegistrationPlace,RegDATE,SeatingCapacity,FuelType,PresentIDV,BasicPremium,LoadingAmt,PremiumAfterLoading,Discount,NoClaimBonus,ServiceTax,EduCess,DepositType,BankName,ChequeNo,ChequeDate,Cancelled,CancelledReason,PolicyStatus,ThirdPartyPrem,PAtoUnnamed,PAtoCarOwner,Remarks,CreateUserIndex,CreateDateTime,ClaimProcess,TPANAME,OldPolicyNo,Status,ApplicationNo,SendToCompany,ReceivedDocument,DispatchMethod,DispatchStatus,Dispatch,BrokerageAmt,DiscountPer,NCBPer,AddOnCover,TerrisiomPremium,HPAIndex,BranchName,MarineSA,RemainingMarineSA,StampDuty,ChequeAmt,Premiumbeforetax,PolicyEndDate,CashAmt,PDate,PAYesNo,Return_Amt,CostPremium,CostPremiumPA,ST_P,Net_Pay,PAPremium,Policy_NoPA,TM_Code,SE_Code,MA_Code,RecdDate,RecdCust,PolicySince,ren_dispatchdate,ren_mode_of_dispatch,ren_dispatchedby,ren_disprmk,Ren_Generated,CancelledDate,planCode,TotalB,IsDeleted,GLoadPerc,Ren_Rec_Date,PODDate,Bulk_Dis_Date,DispatchDate,Ren_PodDate,Mode_of_Dispatch,CourierName,EarthQueckAmt,BasicA,Bulk_Dis_Courier_Name,PolicyStatusFlag,CashVISPL,ChqVISPL,RetVISPL,CashINS,ChqINS,RetINS) VALUES(" + index + "," + accno + ",@ClientIndex,@AgencyIndex,@SubBrokerIndex,@GICompanyIndex,@GITypeIndex,@GroupIndex,@PolicyNo,@GIProductIndex,@LoginDate,@PolicyStartDate,@PolicyExpiryDate,@PremiumAmt,@SAAmt,@GISubType,@Model,@RegNo,@EngineNumber,@ChasisNo,@CubicCapacity,@ManuYear,@VehicleColor,@RegistrationPlace,@RegDATE,@SeatingCapacity,@FuelType,@PresentIDV,@BasicPremium,@LoadingAmt,@PremiumAfterLoading,@Discount,@NoClaimBonus,@ServiceTax,@EduCess,@DepositType,@BankName,@ChequeNo,@ChequeDate,@Cancelled,@CancelledReason,@PolicyStatus,@ThirdPartyPrem,@PAtoUnnamed,@PAtoCarOwner,@Remarks," + createindex + ",getdate(),@ClaimProcess,@TPANAME,@OldPolicyNo,@Status,@ApplicationNo,@SendToCompany,@ReceivedDocument,@DispatchMethod,@DispatchStatus,@Dispatch,@BrokerageAmt,@DiscountPer,@NCBPer,@AddOnCover,@TerrisiomPremium,@HPAIndex,@BranchName,@MarineSA,@RemainingMarineSA,@StampDuty,@ChequeAmt,@Premiumbeforetax,@PolicyEndDate,@CashAmt,@PDate,@PAYesNo,@Return_Amt,@CostPremium,@CostPremiumPA,@ST_P,@Net_Pay,@PAPremium,@Policy_NoPA,@TM_Code,@SE_Code,@MA_Code,@RecdDate,@RecdCust,@PolicySince,@ren_dispatchdate,@ren_mode_of_dispatch,@ren_dispatchedby,@ren_disprmk,@Ren_Generated,@CancelledDate,@planCode,@TotalB,@IsDeleted,@GLoadPerc,@Ren_Rec_Date,@PODDate,@Bulk_Dis_Date,@DispatchDate,@Ren_PodDate,@Mode_of_Dispatch,@CourierName,@EarthQueckAmt,@BasicA,@Bulk_Dis_Courier_Name,@PolicyStatusFlag,@CashVISPL,@ChqVISPL,@RetVISPL,@CashINS,@ChqINS,@RetINS); " + "SELECT GIMastIndex from GI_InsureMaster where GIMastIndex = " + index + "";
        //    var employeeId = CreateContext().Query<int>(sqlQuery, Branch).Single();
        //    // this.Veritasdb.Execute(sqlQuery);
        //    Branch.GIMastIndex = index;
        //    return Branch;
        //}

        //public GiInsureMaster Find(int? id)
        //{
        //    string query = "SELECT GIMastIndex,ClientIndex,AgencyIndex,SubBrokerIndex,GICompanyIndex,GITypeIndex,GroupIndex,PolicyNo,GIProductIndex,LoginDate,PolicyExpiryDate,PremiumAmt,SAAmt,GISubType,Model,RegNo,EngineNumber,ChasisNo,CubicCapacity,ManuYear,VehicleColor,RegistrationPlace,RegDATE,SeatingCapacity,FuelType,PresentIDV,BasicPremium,LoadingAmt,PremiumAfterLoading,Discount,NoClaimBonus,ServiceTax,EduCess,DepositType,BankName,ChequeNo,ChequeDate,Cancelled,CancelledReason,PolicyStatus,ThirdPartyPrem,PAtoUnnamed,PAtoCarOwner,Remarks,CreateUserIndex,UpdateUserIndex,CreateDateTime,UpdateDateTime,ClaimProcess,TPANAME,OldPolicyNo,Status,ApplicationNo,SendToCompany,ReceivedDocument,DispatchMethod,DispatchStatus,Dispatch,BrokerageAmt,DiscountPer,NCBPer,AddOnCover,TerrisiomPremium,HPAIndex,BranchName,MarineSA,RemainingMarineSA,StampDuty,ChequeAmt,Premiumbeforetax,PolicyEndDate,CashAmt,PDate,PAYesNo,Return_Amt,CostPremium,CostPremiumPA,ST_P,Net_Pay,PAPremium,Policy_NoPA,TM_Code,SE_Code,MA_Code,RecdDate,RecdCust,PolicySince,ren_dispatchdate,ren_mode_of_dispatch,ren_dispatchedby,ren_disprmk,Ren_Generated,CancelledDate,planCode,TotalB,IsDeleted,GLoadPerc,Ren_Rec_Date,PODDate,Bulk_Dis_Date,DispatchDate,Ren_PodDate,Mode_of_Dispatch,CourierName,EarthQueckAmt,BasicA,Bulk_Dis_Courier_Name,PolicyStatusFlag,CashVISPL,ChqVISPL,RetVISPL,CashINS,ChqINS,RetINS From GI_InsureMaster WHERE GIMastIndex = " + id + "";
        //    return CreateContext().Query<GiInsureMaster>(query).SingleOrDefault();
        //}

        //public List<GiInsureMaster> GetAll()
        //{
        //    List<GiInsureMaster> empList = CreateContext().Query<GiInsureMaster>("SELECT GIMastIndex,ClientIndex,AgencyIndex,SubBrokerIndex,GICompanyIndex,GITypeIndex,GroupIndex,PolicyNo,GIProductIndex,LoginDate,PolicyExpiryDate,PremiumAmt,SAAmt,GISubType,Model,RegNo,EngineNumber,ChasisNo,CubicCapacity,ManuYear,VehicleColor,RegistrationPlace,RegDATE,SeatingCapacity,FuelType,PresentIDV,BasicPremium,LoadingAmt,PremiumAfterLoading,Discount,NoClaimBonus,ServiceTax,EduCess,DepositType,BankName,ChequeNo,ChequeDate,Cancelled,CancelledReason,PolicyStatus,ThirdPartyPrem,PAtoUnnamed,PAtoCarOwner,Remarks,CreateUserIndex,UpdateUserIndex,CreateDateTime,UpdateDateTime,ClaimProcess,TPANAME,OldPolicyNo,Status,ApplicationNo,SendToCompany,ReceivedDocument,DispatchMethod,DispatchStatus,Dispatch,BrokerageAmt,DiscountPer,NCBPer,AddOnCover,TerrisiomPremium,HPAIndex,BranchName,MarineSA,RemainingMarineSA,StampDuty,ChequeAmt,Premiumbeforetax,PolicyEndDate,CashAmt,PDate,PAYesNo,Return_Amt,CostPremium,CostPremiumPA,ST_P,Net_Pay,PAPremium,Policy_NoPA,TM_Code,SE_Code,MA_Code,RecdDate,RecdCust,PolicySince,ren_dispatchdate,ren_mode_of_dispatch,ren_dispatchedby,ren_disprmk,Ren_Generated,CancelledDate,planCode,TotalB,IsDeleted,GLoadPerc,Ren_Rec_Date,PODDate,Bulk_Dis_Date,DispatchDate,Ren_PodDate,Mode_of_Dispatch,CourierName,EarthQueckAmt,BasicA,Bulk_Dis_Courier_Name,PolicyStatusFlag,CashVISPL,ChqVISPL,RetVISPL,CashINS,ChqINS,RetINS From GI_InsureMaster").ToList();
        //    return empList;
        //}

        //public void Remove(int id)
        //{
        //    var sqlQuery = ("Delete From GI_InsureMaster Where GIMastIndex = " + id + "");
        //    CreateContext().Execute(sqlQuery);
        //}

        //public GiInsureMaster Update(GiInsureMaster Branch)
        //{
        //    var sqlQuery =
        //  "UPDATE GI_InsureMaster " +
        //  "SET ClientIndex = @ClientIndex, " +
        //   " AgencyIndex = @AgencyIndex, " +
        //     " GICompanyIndex = @GICompanyIndex, " +
        //      " GITypeIndex = @GITypeIndex, " +
        //       " GroupIndex = @GroupIndex, " +
        //      " PolicyNo = @PolicyNo, " +
        //       " GIProductIndex = @GIProductIndex, " +
        //   " LoginDate = @LoginDate, " +
        //  " PolicyStartDate = @PolicyStartDate, " +
        //   " PolicyExpiryDate = @PolicyExpiryDate, " +
        //  " PremiumAmt = @PremiumAmt, " +
        //   " SAAmt = @SAAmt, " +
        //  "GISubType = @GISubType, " +
        //   "Model = @Model, " +
        //  "RegNo = @RegNo, " +
        //  " EngineNumber = @EngineNumber, " +
        //   " ChasisNo = @ChasisNo, " +
        //   " CubicCapacity = @CubicCapacity, " +
        //    " ManuYear = @ManuYear, " +
        //   " VehicleColor = @VehicleColor, " +
        //   " RegistrationPlace = @RegistrationPlace, " +
        //     " RegDATE = @RegDATE, " +
        //       " SeatingCapacity = @SeatingCapacity, " +
        //   " FuelType = @FuelType, " +
        //  " PresentIDV = @PresentIDV, " +
        //   " BasicPremium = @BasicPremium, " +
        //  " LoadingAmt = @LoadingAmt, " +
        //   " PremiumAfterLoading = @PremiumAfterLoading, " +
        //  "Discount = @Discount, " +
        //   "NoClaimBonus = @NoClaimBonus, " +
        //  "ServiceTax = @ServiceTax, " +
        //  " EduCess = @EduCess, " +
        //   " DepositType = @DepositType, " +
        //   " BankName = @BankName, " +
        //    " ChequeNo = @ChequeNo, " +
        //   " ChequeDate = @ChequeDate, " +
        //   " Cancelled = @Cancelled, " +
        //    " CancelledReason = @CancelledReason, " +
        //     " PolicyStatus = @PolicyStatus, " +
        //       " ThirdPartyPrem = @ThirdPartyPrem, " +
        //   " PAtoUnnamed = @PAtoUnnamed, " +
        //  " PAtoCarOwner = @PAtoCarOwner, " +
        //   " ClaimProcess = @ClaimProcess, " +
        //  " TPANAME = @TPANAME, " +
        //   " OldPolicyNo = @OldPolicyNo, " +
        //  "Status = @Status, " +
        //   "ApplicationNo = @ApplicationNo, " +
        //  "SendToCompany = @SendToCompany, " +
        //  " ReceivedDocument = @ReceivedDocument, " +
        //   " DispatchMethod = @DispatchMethod, " +
        //   " DispatchStatus = @DispatchStatus, " +
        //    " Dispatch = @Dispatch, " +
        //   " BrokerageAmt = @BrokerageAmt, " +
        //   " DiscountPer = @DiscountPer, " +
        //    " NCBPer = @NCBPer, " +
        //  " AddOnCover = @AddOnCover, " +
        //   " TerrisiomPremium = @TerrisiomPremium, " +
        //   " BranchName = @BranchName, " +
        //  "MarineSA = @MarineSA, " +
        //   "RemainingMarineSA = @RemainingMarineSA, " +
        //  "StampDuty = @StampDuty, " +
        //  " ChequeAmt = @ChequeAmt, " +
        //   " Premiumbeforetax = @Premiumbeforetax, " +
        //   " PolicyEndDate = @PolicyEndDate, " +
        //    " CashAmt = @CashAmt, " +
        //   " PDate = @PDate, " +
        //   " PAYesNo = @PAYesNo, " +
        //      " Return_Amt = @Return_Amt, " +
        //  " CostPremium = @CostPremium, " +
        //   " CostPremiumPA = @CostPremiumPA, " +
        //  " ST_P = @ST_P, " +
        //   " Net_Pay = @Net_Pay, " +
        //  "PAPremium = @PAPremium, " +
        //   "Policy_NoPA = @Policy_NoPA, " +
        //  "TM_Code = @TM_Code, " +
        //  " SE_Code = @SE_Code, " +
        //   " MA_Code = @MA_Code, " +
        //    " RecdDate = @RecdDate, " +
        //   " RecdCust = @RecdCust, " +
        //   " PolicySince = @PolicySince, " +
        //    " ren_dispatchdate = @ren_dispatchdate, " +
        //   " ren_mode_of_dispatch = @ren_mode_of_dispatch, " +
        //   " ren_dispatchedby = @ren_dispatchedby, " +
        //      " ren_disprmk = @ren_disprmk, " +
        //  " Ren_Generated = @Ren_Generated, " +
        //   " CancelledDate = @CancelledDate, " +
        //  " planCode = @planCode, " +
        //   " TotalA = @TotalA, " +
        //  "TotalB = @TotalB, " +
        //   "IsDeleted = @IsDeleted, " +
        //  "GLoadPerc = @GLoadPerc, " +
        //  " Ren_Rec_Date = @Ren_Rec_Date, " +
        //   " PODDate = @PODDate, " +
        //    "Bulk_Dis_Date = @Bulk_Dis_Date, " +
        //  " DispatchDate = @DispatchDate, " +
        //   " Ren_PodDate = @Ren_PodDate, " +
        //    " Mode_of_Dispatch = @Mode_of_Dispatch, " +
        //   " CourierName = @CourierName, " +
        //   " EarthQueckAmt = @EarthQueckAmt, " +
        //    " BasicA = @BasicA, " +
        //   " Bulk_Dis_Courier_Name = @Bulk_Dis_Courier_Name, " +
        //   " PolicyStatusFlag = @PolicyStatusFlag, " +
        //      " CashVISPL = @CashVISPL, " +
        //  " ChqVISPL = @ChqVISPL, " +
        //   " RetVISPL = @RetVISPL, " +
        //  " CashINS = @CashINS, " +
        //   " ChqINS = @ChqINS, " +
        //  "RetINS = @RetINS, " +
        //  " Remarks = @Remarks, " +
        //  "UpdateUserIndex = @UpdateUserIndex, " +
        //  " UpdateDateTime = getDate(), " +
        //  "Discontinue = @Discontinue " +
        //  "WHERE GIMastIndex = @GIMastIndex";
        //    CreateContext().Execute(sqlQuery, Branch);
        //    return Branch;
        //}

        public async Task<IEnumerable<GiInsureMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<GiInsureMaster>(SQLConstants.GetAllInsureMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<GiInsureMasterViewModel>> GetAllInsureMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<GiInsureMasterViewModel>(SQLConstants.GetInsureMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
