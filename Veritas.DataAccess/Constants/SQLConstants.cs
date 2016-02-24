namespace Veritas.DataAccess
{
    public class SQLConstants
    {
        #region LookUps
                
        public static readonly string GICompanyMasterLookUp = "SELECT GICompanyIndex,GICompanyName from GI_CompanyMaster;";
        public static readonly string GIProductTypeMasterLookUp = "SELECT GITypeIndex,GITypeName from GI_ProductTypeMaster;";
        public static readonly string TMMasterLookUp = "SELECT TM_ID,TM_Name from TMMaster;";
        public static readonly string SEMasterLookUp = "SELECT SE_ID,SE_Name from SEMaster;";
        public static readonly string INClientleMasterLookUp = "SELECT ClientleIndex,Full_NM_LA from IN_ClientleMaster;";
        public static readonly string GIAgencyMasterLookUp = "SELECT AgencyIndex,AgencyName from GI_AgencyMaster;";
        public static readonly string MainAgentMasterLookUp = "SELECT MainAgent_ID,MainAgentName from MainAgentMaster;";
        public static readonly string BranchMasterLookUp = "SELECT Branch_ID,FullName from BranchMaster;";
        public static readonly string GIProductMasterLookUp = "SELECT GIProductIndex,GIProductName from GI_ProductMaster;";
        public static readonly string CityMasterLookUp = "SELECT CityIndex,CityName from CityMaster;";
        public static readonly string StateMasterLookUp = "SELECT StateIndex,StateName from StateMaster;";
        public static readonly string CountryMasterLookUp = "SELECT CountryIndex,CountryName from CountryMaster;";
        public static readonly string ASMMasterLookUp = "SELECT ASMIndex,ASMName from ASMMaster;";
        #endregion

        #region InsureMaster
        /// <summary>
        /// Gets All Insure Master table records
        /// </summary>
        public static readonly string GetAllInsureMastersQuery = "SELECT GIMastIndex,ClientIndex,AgencyIndex,SubBrokerIndex,GICompanyIndex,GITypeIndex,GroupIndex,PolicyNo,GIProductIndex,LoginDate,PolicyExpiryDate,PremiumAmt,SAAmt,GISubType,Model,RegNo,EngineNumber,ChasisNo,CubicCapacity,ManuYear,VehicleColor,RegistrationPlace,RegDATE,SeatingCapacity,FuelType,PresentIDV,BasicPremium,LoadingAmt,PremiumAfterLoading,Discount,NoClaimBonus,ServiceTax,EduCess,DepositType,BankName,ChequeNo,ChequeDate,Cancelled,CancelledReason,PolicyStatus,ThirdPartyPrem,PAtoUnnamed,PAtoCarOwner,Remarks,CreateUserIndex,UpdateUserIndex,CreateDateTime,UpdateDateTime,ClaimProcess,TPANAME,OldPolicyNo,Status,ApplicationNo,SendToCompany,ReceivedDocument,DispatchMethod,DispatchStatus,Dispatch,BrokerageAmt,DiscountPer,NCBPer,AddOnCover,TerrisiomPremium,HPAIndex,BranchName,MarineSA,RemainingMarineSA,StampDuty,ChequeAmt,Premiumbeforetax,PolicyEndDate,CashAmt,PDate,PAYesNo,Return_Amt,CostPremium,CostPremiumPA,ST_P,Net_Pay,PAPremium,Policy_NoPA,TM_Code,SE_Code,MA_Code,RecdDate,RecdCust,PolicySince,ren_dispatchdate,ren_mode_of_dispatch,ren_dispatchedby,ren_disprmk,Ren_Generated,CancelledDate,planCode,TotalB,IsDeleted,GLoadPerc,Ren_Rec_Date,PODDate,Bulk_Dis_Date,DispatchDate,Ren_PodDate,Mode_of_Dispatch,CourierName,EarthQueckAmt,BasicA,Bulk_Dis_Courier_Name,PolicyStatusFlag,CashVISPL,ChqVISPL,RetVISPL,CashINS,ChqINS,RetINS From GI_InsureMaster";

        public static readonly string GetInsureMasterViewModelQuery = "SELECT IM.GIMastIndex, IM.PolicyNo,CM.GICompanyName,CliM.Full_NM_LA, IM.LoginDate, IM.PolicyStartDate FROM GI_InsureMaster IM LEFT JOIN GI_CompanyMaster CM ON IM.GICompanyIndex = CM.GICompanyIndex LEFT JOIN IN_ClientleMaster CliM ON IM.ClientIndex = CliM.ClientleIndex";

        #endregion

        #region AgentType Master
        /// <summary>
        /// Gets All AgentType Master table records
        /// </summary>
        public static readonly string GetAllAgentTypeMastersQuery = "SELECT AgentTypeID,Name,Businesstype,Remarks,CreateUserIndex,CreateDateTime,UpdateUserIndex,UpdateDateTime,Discontinue FROM AgentTypeMaster";

        public static readonly string GetAgentTypeViewModelQuery = "SELECT AgentTypeID,Name,Businesstype FROM AgentTypeMaster";

        public static readonly string InsertAgentTypeMaster = "INSERT INTO AgentTypeMaster (AgentTypeID,Name,Businesstype,Remarks,CreateUserIndex,CreateDateTime,Discontinue) VALUES(@AgentTypeID,@Name,@Businesstype,@Remarks,@CreateUserIndex,@CreateDateTime,@Discontinue);" + "SELECT AgentTypeID from AgentTypeMaster where AgentTypeID = @AgentTypeID";
        #endregion

        #region GiAgency Master
        /// <summary>
        /// Gets All Agency Master table records
        /// </summary>
        public static readonly string GetAllGiAgencyMastersQuery = "SELECT AgencyIndex,AgencyName,AgencyCode,CompanyIndex,COM.GICompanyName as CompanyName,DateOfEnrollment,DateOfExpiration,PAN_No,BankName,BranchName,AccountType,AccountNo,MICRCode,IFSCCode,AM.Address1,AM.Address2,AM.Pincode,AM.CityIndex,ARM.CityName,AM.StateIndex,SM.StateName,AM.Email,PhoneNo1,PhoneNo2,MobileNo,AM.Remarks,AM.Discontinue FROM GI_AgencyMaster AM left outer join CityMaster ARM on AM.CityIndex = ARM.CityIndex left outer join StateMaster SM on AM.StateIndex = SM.StateIndex left outer join GI_CompanyMaster COM on AM.CompanyIndex = COM.GICompanyIndex";

        public static readonly string GetGiAgencyMasterViewModelQuery = "SELECT AgencyIndex,AgencyName,COM.GICompanyName as CompanyName FROM GI_AgencyMaster AM left outer join GI_CompanyMaster COM on AM.CompanyIndex = COM.GICompanyIndex";

        public static readonly string InsertGiAgencyMaster = "INSERT INTO GI_AgencyMaster (AgencyIndex,AgencyName,AgencyCode,CompanyIndex,DateOfEnrollment,DateOfExpiration,PAN_No,BankName,BranchName,AccountType,AccountNo,MICRCode,IFSCCode,Address1,Address2,Pincode,CityIndex,StateIndex,Email,PhoneNo1,PhoneNo2,MobileNo,Remarks,CreateUserIndex,CreateDateTime,Discontinue) VALUES(@AgencyIndex,@AgencyName,@AgencyCode,@CompanyIndex,@DateOfEnrollment,@DateOfExpiration,@PAN_No,@BankName,@BranchName,@AccountType,@AccountNo,@MICRCode,@IFSCCode,@Address1,@Address2,@Pincode,@CityIndex,@StateIndex,@Email,@PhoneNo1,@PhoneNo2,@MobileNo,@Remarks,@CreateUserIndex,@CreateDateTime,@Discontinue);" + "SELECT AgencyIndex from GI_AgencyMaster where AgencyIndex = @AgencyIndex";
        #endregion

        #region Division Master
        /// <summary>
        /// Gets All Division Master table records
        /// </summary>
        public static readonly string GetAllDivisionMastersQuery = "SELECT DivisionIndex,Division,Vertical,Remarks,CreateUserIndex,CreateDateTime,UpdateUserIndex,UpdateDateTime,Discontinue FROM DivisionMaster";

        public static readonly string GetDivisionMasterViewModelQuery = "SELECT DivisionIndex,Division,Vertical FROM DivisionMaster";

        public static readonly string InsertDivisionMaster = "INSERT INTO DivisionMaster (DivisionIndex,Division,Vertical,Remarks,CreateUserIndex,CreateDateTime,Discontinue) VALUES(@DivisionIndex,@Division,@Vertical,@Remarks,@CreateUserIndex,@CreateDateTime,@Discontinue);" + "SELECT DivisionIndex from DivisionMaster where DivisionIndex = @DivisionIndex";

        #endregion

        #region Branch Master
        /// <summary>
        /// Gets All Branch Master table records
        /// </summary>
        public static readonly string GetAllBranchMastersQuery = "SELECT Branch_ID,FullName,UserName,Password,Type,House_FlatNo,Street,Landmark,BM.CityIndex,CM.CityName,BM.StateIndex,SM.StateName,Pincode,Cont_MobileNo,Cont1,Cont2,Cont_Email,LoginStatus,BM.Remarks,BM.Discontinue FROM BranchMaster";

        public static readonly string GetBranchMasterViewModelQuery = "SELECT Branch_ID,FullName,UserName,Password,Type FROM BranchMaster";

        public static readonly string InsertBranchMaster = "INSERT INTO BranchMaster (Branch_ID,FullName,UserName,Password,Type,House_FlatNo,Street,Landmark,CityIndex,StateIndex,Pincode,Cont_MobileNo,Cont1,Cont2,Cont_Email,LoginStatus,Remarks,CreateUserIndex,CreateDateTime,Discontinue) VALUES(@Branch_ID,@FullName,@UserName,@Password,@Type,@House_FlatNo,@Street,@Landmark,@CityIndex,@StateIndex,@Pincode,@Cont_MobileNo,@Cont1,@Cont2,@Cont_Email,@LoginStatus,@Remarks,@CreateUserIndex,@CreateDateTime,@Discontinue);" + "SELECT Branch_ID from BranchMaster where Branch_ID = @Branch_ID";
        #endregion

        #region ASM Master
        /// <summary>
        /// Gets All ASM Master table records
        /// </summary>
        public static readonly string GetAllAsmMastersQuery = "SELECT ASMIndex,ASM_Name,Type,UserName,Password,House_FlatNo,Street,Landmark,ASM.AreaIndex,AM.AreaName,ASM.CityIndex,CM.CityName,ASM.StateIndex,SM.StateName,ASM.Pincode,MobileNo,Cont1,Cont2,Email,LoginStatus,ASM.Remarks,ASM.Discontinue FROM ASMMaster ASM left outer join AreaMaster AM on ASM.AreaIndex = AM.AreaIndex left outer join CityMaster CM on ASM.CityIndex = CM.CityIndex left outer join StateMaster SM on ASM.StateIndex = SM.StateIndex";

        public static readonly string GetAsmMasterViewModelQuery = "SELECT ASMIndex,ASM_Name,Type,UserName,Password FROM ASMMaster";

        public static readonly string InsertASMMaster = "INSERT INTO ASMMaster (ASMIndex,ASM_Name,Type,UserName,Password,House_FlatNo,Street,Landmark,AreaIndex,CityIndex,StateIndex,Pincode,MobileNo,Cont1,Cont2,Email,LoginStatus,Remarks,CreateUserIndex,CreateDateTime,Discontinue) VALUES(@ASMIndex,@ASM_Name,@Type,@UserName,@Password,@House_FlatNo,@Street,@Landmark,@AreaIndex,@CityIndex,@StateIndex,@Pincode,@MobileNo,@Cont1,@Cont2,@Email,@LoginStatus,@Remarks,@CreateUserIndex,@CreateDateTime,@Discontinue);" + "SELECT ASMIndex from ASMMaster where ASMIndex = @ASMIndex";
        #endregion

        #region Main Agent Master
        /// <summary>
        /// Gets All Main Agent Master table records
        /// </summary>
        public static readonly string GetAllMainAgentMastersQuery = "SELECT MainAgent_ID,MainAgentName,MA.SE_ID,SE.SE_Name,BranchID,BM.FullName as BranchName,MA.ASMIndex,ASM.ASM_Name as ASMName,MA.UserName,MA.Password,MA.House_FlatNo,MA.Street,MA.Landmark,MA.AreaIndex,AM.AreaName,MA.CityIndex,CM.CityName,MA.StateIndex,SM.StateName,MA.Pincode,MA.MobileNo,MA.Cont1,MA.Cont2,MA.Cont_Email,AllowCommision,WatchFlag,MA.LoginStatus,MA.Remarks,MA.Discontinue FROM MainAgentMaster MA left outer join AreaMaster AM on MA.AreaIndex = AM.AreaIndex left outer join CityMaster CM on MA.CityIndex = CM.CityIndex left outer join StateMaster SM on MA.StateIndex = SM.StateIndex left outer join SEMaster SE on MA.SE_ID = SE.SE_ID left outer join BranchMaster BM on MA.BranchID = BM.Branch_ID left outer join ASMMaster ASM on MA.ASMIndex = ASM.ASMIndex";

        public static readonly string GetMainAgentMasterViewModelQuery = "SELECT MainAgent_ID,MainAgentName,MA.UserName,MA.Password FROM MainAgentMaster MA";

        public static readonly string InsertMainAgentMaster = "INSERT INTO MainAgentMaster (MainAgent_ID,MainAgentName,SE_ID,BranchID,ASMIndex,UserName,Password,House_FlatNo,Street,Landmark,AreaIndex,CityIndex,StateIndex,Pincode,MobileNo,Cont1,Cont2,Cont_Email,AllowCommision,WatchFlag,LoginStatus,Remarks,CreateUserIndex,CreateDateTime,Discontinue) VALUES(@MainAgent_ID,@MainAgentName,@SE_ID,@BranchID,@ASMIndex,@UserName,@Password,@House_FlatNo,@Street,@Landmark,@AreaIndex,@CityIndex,@StateIndex,@Pincode,@MobileNo,@Cont1,@Cont2,@Cont_Email,@AllowCommision,@WatchFlag,@LoginStatus,@Remarks,@CreateUserIndex,@CreateDateTime,@Discontinue);" + "SELECT MainAgent_ID from MainAgentMaster where MainAgent_ID = @MainAgent_ID";
        #endregion

        #region SE Master
        /// <summary>
        /// Gets All SE Master table records
        /// </summary>
        public static readonly string GetAllSEMastersQuery = "SELECT SE_ID,SE_Name,SECode,ASM.Branch_ID,BM.FullName as BranchName,ASM.TM_ID,TM.TM_Name as TMName,ASM.Gender,ASM.JoinDate,ASM.RegDate,ASM.DivisionID,DIV.Division,ASM.UserName,ASM.Password,ASM.House_FlatNo,ASM.Street,ASM.Landmark,ASM.AreaIndex,AM.AreaName,ASM.CityIndex,CM.CityName,ASM.StateIndex,SM.StateName,ASM.Pincode,ASM.MobileNo,ASM.Cont1,ASM.Cont2,ASM.Email,ASM.LoginStatus,ASM.Remarks,ASM.Discontinue FROM SEMaster ASM left outer join AreaMaster AM on ASM.AreaIndex = AM.AreaIndex left outer join CityMaster CM on ASM.CityIndex = CM.CityIndex left outer join StateMaster SM on ASM.StateIndex = SM.StateIndex left outer join BranchMaster BM on ASM.Branch_ID = BM.Branch_ID left outer join TMMaster TM on ASM.TM_ID = TM.TM_ID left outer join DivisionMaster DIV on ASM.DivisionID = DIV.DivisionIndex";

        public static readonly string GetSEMasterViewModelQuery = "SELECT SE_ID,SE_Name,SECode,UserName,Password FROM SEMaster ASM ";

        #endregion

        #region TM Master
        /// <summary>
        /// Gets All SE Master table records
        /// </summary>
        public static readonly string GetAllTmMastersQuery = "SELECT TM_ID,TM_Name,ASM_ID,ASM.ASM_Name,Gender,JoinDate,RegDate,DivisionID,DIV.Division,TM.UserName,TM.Password,TM.House_FlatNo,TM.Street,TM.Landmark,TM.AreaIndex,AM.AreaName,TM.CityIndex,CM.CityName,TM.StateIndex,SM.StateName,TM.Pincode,TM.MobileNo,TM.Cont1,TM.Cont2,TM.Email,TM.LoginStatus,TM.Remarks,TM.Discontinue FROM TMMaster TM left outer join AreaMaster AM on TM.AreaIndex = AM.AreaIndex left outer join CityMaster CM on TM.CityIndex = CM.CityIndex left outer join StateMaster SM on TM.StateIndex = SM.StateIndex left outer join ASMMaster ASM on TM.ASM_ID = ASM.ASMIndex left outer join DivisionMaster DIV on TM.DivisionID = DIV.DivisionIndex";

        public static readonly string GetTmMasterViewModelQuery = "SELECT TM_ID,TM_Name,DIV.Division,TM.UserName,TM.Password FROM TMMaster TM left outer join DivisionMaster DIV on TM.DivisionID = DIV.DivisionIndex ";

        #endregion

        #region Sub Agent Master
        /// <summary>
        /// Gets All SE Master table records
        /// </summary>
        public static readonly string GetAllSubAgentMastersQuery = "SELECT TM_ID,TM_Name,ASM_ID,ASM.ASM_Name,Gender,JoinDate,RegDate,DivisionID,DIV.Division,TM.UserName,TM.Password,TM.House_FlatNo,TM.Street,TM.Landmark,TM.AreaIndex,AM.AreaName,TM.CityIndex,CM.CityName,TM.StateIndex,SM.StateName,TM.Pincode,TM.MobileNo,TM.Cont1,TM.Cont2,TM.Email,TM.LoginStatus,TM.Remarks,TM.Discontinue FROM TMMaster TM left outer join AreaMaster AM on TM.AreaIndex = AM.AreaIndex left outer join CityMaster CM on TM.CityIndex = CM.CityIndex left outer join StateMaster SM on TM.StateIndex = SM.StateIndex left outer join ASMMaster ASM on TM.ASM_ID = ASM.ASMIndex left outer join DivisionMaster DIV on TM.DivisionID = DIV.DivisionIndex";

        public static readonly string GetSubAgentMasterViewModelQuery = "SELECT TM_ID,TM_Name,DIV.Division,TM.UserName,TM.Password FROM TMMaster TM left outer join DivisionMaster DIV on TM.DivisionID = DIV.DivisionIndex ";

        #endregion

        #region Client Master
        /// <summary>
        /// Gets All SE Master table records
        /// </summary>
        public static readonly string GetAllInClientleMastersQuery = "SELECT CLM.ClientleIndex,CLM.GroupIndex,CLM.BranchID,BM.FullName as BranchName,GRP.Full_NM_LA as GroupHead,CLM.Full_NM_LA,CLM.FatherName,CLM.DOB_LA,CLM.Gender,CLM.Maritial_Status,CLM.Anniversary,CLM.Nationality,CLM.Pan_No,CLM.Comm_House_FlatNo,CLM.Comm_Street,CLM.Comm_Address,CLM.Comm_Landmark,CLM.Comm_AreaIndex,am.AreaName as Comm_AreaName,CLM.Comm_CityIndex,cm.CityName as Comm_CityName,CLM.Comm_PinCode,CLM.Comm_StateIndex,sm.StateName as Comm_StateName,CLM.Comm_CountryIndex,con.CountryName as Comm_CountryName,CLM.Cont_MobileNo,CLM.Cont_Home,CLM.Cont_Fax,CLM.Cont_Office,CLM.Cont_Email,CLM.Res_House_FlatNo,CLM.Res_Street,CLM.Res_Address,CLM.Res_Landmark,CLM.Res_AreaIndex,am_res.AreaName as Res_AreaName,CLM.Res_CityIndex,cm_res.CityName as Res_CityName,CLM.Res_StateIndex,sm_res.StateName as Res_StateName,CLM.Res_CountryIndex,con_res.CountryName as Res_CountryName,CLM.Res_Pincode,CLM.Res_Mobile,CLM.Res_Phone,CLM.Res_Email,CLM.OccupationDetail,CLM.Designation,CLM.EMP_Year,CLM.Yearly_Gross_Income,CLM.BusinessType,CLM.Bus_BldgNameNo,CLM.Bus_Street,CLM.Bus_Address,CLM.Bus_Landmark,CLM.Bus_AreaIndex,am_Bus.AreaName as Bus_AreaName,CLM.Bus_CityIndex,cm_Bus.CityName as Bus_CityName,CLM.Bus_StateIndex,sm_Bus.StateName as Bus_StateName,CLM.Bus_Pincode,CLM.Bus_CountryIndex,con_Bus.CountryName as Bus_CountryName,CLM.Bus_Email,CLM.Name_Employer,CLM.Comp_Type,CLM.Department,CLM.Office_BldgNameNo,CLM.Office_Street,CLM.Office_Address,CLM.Office_Landmark,CLM.Office_AreaIndex,am_Office.AreaName as Office_AreaName,CLM.Office_CityIndex,cm_Office.CityName as Office_CityName,CLM.Office_StateIndex,sm_Office.StateName as Office_StateName,CLM.Office_Pincode,CLM.Office_CountryIndex,con_Office.CountryName as Office_CountryName,CLM.Office_Email,CLM.Relation_With_LA,CLM.PHONE_R2,CLM.PHONE_O2,CLM.Mobile2,CLM.Co_Mobile1,CLM.Co_Phone1,CLM.Co_Email1,CLM.Co_address_Same,CLM.Per_address_Same,CLM.Watch_flag,CLM.SE_CODE,SE.SE_Name,CLM.SA_CODE,SA.SubAgentName,CLM.MA_CODE,MA.MainAgentName,CLM.Group_Head,CLM.Group_Defined,CLM.Client_Match_Index,CLM.Client_Match,clm.Discontinue,CLM.UserCode,CLM.Password,CLM.Age FROM IN_ClientleMaster clm left outer join CityMaster cm on clm.Comm_CityIndex = cm.CityIndex left outer join StateMaster sm on clm.Comm_StateIndex = sm.StateIndex left outer join AreaMaster am on clm.Comm_AreaIndex = am.AreaIndex left outer join CountryMaster con on clm.Comm_CountryIndex = con.CountryIndex left outer join AreaMaster am_res on clm.Res_AreaIndex = am_res.AreaIndex left outer join CityMaster cm_res on clm.Res_CityIndex = cm_res.CityIndex left outer join StateMaster sm_res on clm.Res_StateIndex = sm_res.StateIndex left outer join CountryMaster con_res on clm.Res_CountryIndex = con_res.CountryIndex left outer join AreaMaster am_Bus on clm.Bus_AreaIndex = am_Bus.AreaIndex left outer join CityMaster cm_Bus on clm.Bus_CityIndex = cm_Bus.CityIndex left outer join StateMaster sm_Bus on clm.Bus_StateIndex = sm_Bus.StateIndex left outer join CountryMaster con_Bus on clm.Bus_CountryIndex = con_Bus.CountryIndex left outer join AreaMaster am_Office on clm.Office_AreaIndex = am_Office.AreaIndex left outer join CityMaster cm_Office on clm.Office_CityIndex = cm_Office.CityIndex left outer join StateMaster sm_Office on clm.Office_StateIndex = sm_Office.StateIndex left outer join CountryMaster con_Office on clm.Office_CountryIndex = con_Office.CountryIndex left outer join SEMaster SE on clm.SE_CODE = SE.SE_ID left outer join SubAgentMaster SA on clm.SA_CODE = SA.SubAgent_ID left outer join MainAgentMaster MA on clm.MA_CODE = MA.MainAgent_ID left outer join IN_ClientleMaster GRP on CLM.GroupIndex = GRP.ClientleIndex left outer join BranchMaster BM on BM.Branch_ID = CLM.BranchID";

        public static readonly string GetInClientleMasterViewModelQuery = "SELECT CLM.ClientleIndex,CLM.GroupIndex,GRP.Full_NM_LA as GroupHead,CLM.Full_NM_LA,CLM.FatherName,CLM.DOB_LA FROM IN_ClientleMaster clm left outer join IN_ClientleMaster GRP on CLM.GroupIndex = GRP.ClientleIndex ";

        #endregion

        #region Country Master
        /// <summary>
        /// Gets All SE Master table records
        /// </summary>
        public static readonly string GetAllCountryMastersQuery = "SELECT CountryIndex,CountryName,Remarks,CreateUserIndex,CreateDateTime,UpdateUserIndex,UpdateDateTime,Discontinue FROM CountryMaster";

        public static readonly string GetCountryMasterViewModelQuery = "SELECT CountryIndex,CountryName FROM CountryMaster";

        public static readonly string InsertCountryMaster = "INSERT INTO CountryMaster (CountryIndex,CountryName,Remarks,CreateUserIndex,CreateDateTime,Discontinue) VALUES(@CountryIndex,@CountryName,@Remarks,@CreateUserIndex,@CreateDateTime,@Discontinue);" + "SELECT CountryIndex from CountryMaster where CountryIndex = @CountryIndex";

        #endregion

        #region Company Master
        public static readonly string GetAllCompanyMasterQuery = "SELECT GICompanyIndex,GICompanyName,Address1,Address2,City,PinCode,Contact1,Contact2,Fax,Email,Website,Remarks,CreateUserIndex,CreateDateTime,UpdateUserIndex,UpdateDateTime,Discontinue FROM GI_CompanyMaster";

        public static readonly string GetCompanyMasterViewModelQuery = "SELECT GICompanyIndex,GICompanyName,Website,Discontinue FROM GI_CompanyMaster";

        public static readonly string InsertGiCompanyMaster = "INSERT INTO GI_CompanyMaster (GICompanyIndex,GICompanyName,Address1,Address2,City,PinCode,Contact1,Contact2,Fax,Email,Website,Remarks,CreateUserIndex,CreateDateTime,Discontinue) VALUES(@GICompanyIndex,@GICompanyName, @Address1,@Address2,@City,@PinCode,@Contact1,@Contact2,@Fax,@Email,@Website,@Remarks,@CreateUserIndex,@CreateDateTime,@Discontinue);" + "SELECT GICompanyIndex from GI_CompanyMaster where GICompanyIndex = @GICompanyIndex";

        #endregion

        #region Product Master
        public static readonly string GetAllProductMasterQuery = "SELECT pm.GIProductIndex,pm.GICompanyIndex,cm.GICompanyName,pm.GIProductName,pm.GITypeIndex,ptm.GITypeName,pm.GIProductStartDate,pm.GIProductEndDate,pm.Remarks,pm.Discontinue FROM GI_ProductMaster pm left outer join GI_CompanyMaster cm on pm.GICompanyIndex = cm.GICompanyIndex left outer join GI_ProductTypeMaster ptm on pm.GITypeIndex = ptm.GITypeIndex";

        public static readonly string GetProductMasterViewModelQuery = "SELECT pm.GIProductIndex,cm.GICompanyName,pm.GIProductName,ptm.GITypeName FROM GI_ProductMaster pm left outer join GI_CompanyMaster cm on pm.GICompanyIndex = cm.GICompanyIndex left outer join GI_ProductTypeMaster ptm on pm.GITypeIndex = ptm.GITypeIndex";

        public static readonly string InsertProductMaster = "INSERT INTO GI_ProductMaster (GIProductIndex,GICompanyIndex,GIProductName,GITypeIndex,GIProductStartDate,GIProductEndDate,Remarks,CreateUserIndex,CreateDateTime,Discontinue) VALUES(@GIProductIndex,@GICompanyIndex, @GIProductName,@GITypeIndex,@GIProductStartDate,@GIProductEndDate,@Remarks,@CreateUserIndex,@CreateDateTime,@Discontinue);SELECT GIProductIndex FROM GI_ProductMaster WHERE GIProductIndex = @GIProductIndex";

        #endregion

        #region ProductType Master
        public static readonly string GetAllProductTypeMasterQuery = "SELECT GITypeIndex,GITypeName,Remarks,CreateUserIndex,CreateDateTime,UpdateUserIndex,UpdateDateTime,Discontinue FROM GI_ProductTypeMaster";

        public static readonly string GetProductTypeMasterViewModelQuery = "SELECT GITypeIndex,GITypeName FROM GI_ProductTypeMaster";

        public static readonly string InsertProductTypeMaster = "INSERT INTO GI_ProductTypeMaster (GITypeIndex,GITypeName,Remarks,CreateUserIndex,CreateDateTime,Discontinue) VALUES(@GITypeIndex,@GITypeName,@Remarks,@CreateUserIndex,@CreateDateTime,@Discontinue);" + "SELECT GITypeIndex from GI_ProductTypeMaster where GITypeIndex = @GITypeIndex";
        #endregion

        #region Area Master
        public static readonly string GetAllAreaMasterQuery = "SELECT am.AreaIndex,am.AreaName,am.PinCode,am.CityIndex,cm.CityName,am.Remarks,am.Discontinue FROM AreaMaster am left outer join CityMaster cm on am.CityIndex = cm.CityIndex";

        public static readonly string GetAreaMasterViewModelQuery = "SELECT am.AreaIndex,am.AreaName,am.PinCode,cm.CityName FROM AreaMaster am left outer join CityMaster cm on am.CityIndex = cm.CityIndex";

        public static readonly string InsertAreaMaster = "INSERT INTO AreaMaster (AreaIndex,AreaName,CityIndex,PinCode,Remarks,CreateUserIndex,CreateDateTime,Discontinue) VALUES(@AreaIndex,@AreaName,@CityIndex,@PinCode,@Remarks,@CreateUserIndex,@CreateDateTime,@Discontinue);" + "SELECT AreaIndex from AreaMaster where AreaIndex = @AreaIndex";
        #endregion

        #region State Master
        public static readonly string GetAllStateMasterQuery = "SELECT sm.StateIndex,sm.StateName,sm.CountryIndex,cm.CountryName,sm.Remarks,sm.Discontinue FROM StateMaster sm left outer join CountryMaster cm on sm.CountryIndex = cm.CountryIndex";

        public static readonly string GetStateMasterViewModelQuery = "SELECT sm.StateIndex,sm.StateName,cm.CountryName FROM StateMaster sm left outer join CountryMaster cm on sm.CountryIndex = cm.CountryIndex";

        public static readonly string InsertStateMaster = "INSERT INTO StateMaster (StateIndex,StateName,CountryIndex,Remarks,CreateUserIndex,CreateDateTime,Discontinue) VALUES(@StateIndex,@StateName,@CountryIndex,@Remarks,@CreateUserIndex,@CreateDateTime,@Discontinue);" + "SELECT StateIndex from StateMaster where StateIndex = @StateIndex";
        #endregion


        #region City Master
        public static readonly string GetAllCityMasterQuery = "SELECT cm.CityIndex,cm.CityName,cm.StateIndex,sm.StateName,cm.STDCode,cm.Remarks,cm.Discontinue FROM CityMaster cm left outer join StateMaster sm on cm.StateIndex = sm.StateIndex";

        public static readonly string GetCityMasterViewModelQuery = "SELECT cm.CityIndex,cm.CityName,sm.StateName FROM CityMaster cm left outer join StateMaster sm on cm.StateIndex = sm.StateIndex";

        public static readonly string InsertCityMaster = "INSERT INTO CityMaster (CityIndex,CityName,StateIndex,STDCode,Remarks,CreateUserIndex,CreateDateTime,Discontinue) VALUES(@CityIndex,@CityName,@StateIndex,@STDCode,@Remarks,@CreateUserIndex,@CreateDateTime,@Discontinue);" + "SELECT CityIndex from CityMaster where CityIndex = @CityIndex";
        #endregion
    }
}
