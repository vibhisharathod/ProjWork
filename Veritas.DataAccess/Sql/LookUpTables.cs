﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;

namespace Veritas.DataAccess.Sql
{
    public class LookUpTables : BaseRepository, ILookUpTables
    {
        public IEnumerable<ClaimProcessTypes> ClaimProcessTypes()
        {
            var claimTypes = new List<ClaimProcessTypes>();
            claimTypes.Add(new ClaimProcessTypes() {Text = "Direct", Value = "Direct" });
            claimTypes.Add(new ClaimProcessTypes() { Text = "TPA", Value = "TPA" });

            return claimTypes;
        }

        /// <summary>
        /// GI_AgencyMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<GiAgencyMaster>> GetAgencyLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<GiAgencyMaster>(SQLConstants.GIAgencyMasterLookUp);
                return lookUpLists;
            });
        }

        /// <summary>
        /// BranchMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<BranchMaster>> GetBranchLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<BranchMaster>(SQLConstants.BranchMasterLookUp);
                return lookUpLists;
            });
        }

        public IEnumerable<BusinessStatus> GetBusinessStatus()
        {
            var businessList = new List<BusinessStatus>();
            businessList.Add(new BusinessStatus() { Text = "New", Value = "New" });
            businessList.Add(new BusinessStatus() { Text = "ReNew", Value = "ReNew" });
            businessList.Add(new BusinessStatus() { Text = "Rollover", Value = "Rollover" });

            return businessList;
        }

        /// <summary>
        /// IN_ClientleMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<InClientleMaster>> GetClientLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<InClientleMaster>(SQLConstants.INClientleMasterLookUp);
                return lookUpLists;
            });
        }

        /// <summary>
        /// GI_CompanyMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<GiCompanyMaster>> GetCompanyLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<GiCompanyMaster>(SQLConstants.GICompanyMasterLookUp);
                return lookUpLists;
            });
        }

        /// <summary>
        /// GI_ProductMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<GiProductMaster>> GetProductLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<GiProductMaster>(SQLConstants.GIProductMasterLookUp);
                return lookUpLists;
            });
        }

        /// <summary>
        /// MainAgentMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<MainAgentMaster>> GetMALookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<MainAgentMaster>(SQLConstants.MainAgentMasterLookUp);
                return lookUpLists;
            });
        }
        /// <summary>
        /// SubAgentMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<SubAgentMaster>> GetSALookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<SubAgentMaster>(SQLConstants.SubAgentMasterLookUp);
                return lookUpLists;
            });
        }
        public IEnumerable<PaymentTypes> GetPaymentTypes()
        {
            var paymentTypes = new List<PaymentTypes>();
            paymentTypes.Add(new PaymentTypes() {Text = "Cash", Value = "Cash" });
            paymentTypes.Add(new PaymentTypes() { Text = "Cheque/DD", Value = "Cheque/DD" });
            paymentTypes.Add(new PaymentTypes() { Text = "Credit Card", Value = "Credit Card" });
            return paymentTypes;
        }

        public IEnumerable<PolicyStatus> GetPolicyStatus()
        {
            var policyStatuses = new List<PolicyStatus>();
            policyStatuses.Add(new PolicyStatus() { Text = "Proposal", Value = "Proposal" });
            policyStatuses.Add(new PolicyStatus() { Text = "Policy", Value = "Policy" });
            return policyStatuses;
        }

        

        public IEnumerable<ProductSubTypes> GetProductSubTypes()
        {
            var productSubTypes = new List<ProductSubTypes>();
            productSubTypes.Add(new ProductSubTypes() { Text = "Private Car", Value = "Private Car" });
            productSubTypes.Add(new ProductSubTypes() { Text = "Two Wheeler", Value = "Two Wheeler" });
            productSubTypes.Add(new ProductSubTypes() { Text = "Commercial Vehicle", Value = "Commercial Vehicle" });
            productSubTypes.Add(new ProductSubTypes() { Text = "Commercial Vehicle Third Party", Value = "Commercial Vehicle Third Party" });
            return productSubTypes;
        }

        /// <summary>
        /// SEMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<SeMaster>> GetSELookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<SeMaster>(SQLConstants.SEMasterLookUp);
                return lookUpLists;
            });
        }

        /// <summary>
        /// TMMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TmMaster>> GetTMLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<TmMaster>(SQLConstants.TMMasterLookUp);
                return lookUpLists;
            });
        }

        /// <summary>
        /// GI_ProductTypeMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<GiProductTypeMaster>> GetTypeLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<GiProductTypeMaster>(SQLConstants.GIProductTypeMasterLookUp);
                return lookUpLists;
            });
        }

        /// <summary>
        /// DivisionMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<DivisionMaster>> GetDivisionLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<DivisionMaster>(SQLConstants.DivisionMasterLookUp);
                return lookUpLists;
            });
        }

        public IEnumerable<VerticalTypes> GetVerticalTypes()
        {
            var VerticalTypes = new List<VerticalTypes>();
            VerticalTypes.Add(new VerticalTypes() { Text = "Direct", Value = "Direct" });
            VerticalTypes.Add(new VerticalTypes() { Text = "In-Direct", Value = "In-Direct" });

            return VerticalTypes;
        }
        /// <summary>
        /// AreaMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AreaMaster>> GetAreaLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<AreaMaster>(SQLConstants.AreaMasterLookUp);
                return lookUpLists;
            });
        }
        /// <summary>
        /// CityMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CityMaster>> GetCityLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<CityMaster>(SQLConstants.CityMasterLookUp);
                return lookUpLists;
            });
        }
        /// <summary>
        /// StateMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<StateMaster>> GetStateLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<StateMaster>(SQLConstants.StateMasterLookUp);
                return lookUpLists;
            });
        }
        /// <summary>
        /// CountryMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CountryMaster>> GetCountryLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<CountryMaster>(SQLConstants.CountryMasterLookUp);
                return lookUpLists;
            });
        }

        public IEnumerable<ACType> GetACTypes()
        {
            var ACType = new List<ACType>();
            ACType.Add(new ACType() { Text = "Current", Value = "Current" });
            ACType.Add(new ACType() { Text = "Savings", Value = "Savings" });

            return ACType;
        }
        public IEnumerable<BranchType> GetBranchTypes()
        {
            var BranchType = new List<BranchType>();
            BranchType.Add(new BranchType() { Text = "Branch", Value = "Branch" });
            BranchType.Add(new BranchType() { Text = "BP", Value = "BP" });

            return BranchType;
        }

        public IEnumerable<ASMTypes> GetASMTypes()
        {
            var ASMTypes = new List<ASMTypes>();
            ASMTypes.Add(new ASMTypes() { Text = "ASM", Value = "ASM" });
            ASMTypes.Add(new ASMTypes() { Text = "BP", Value = "BP" });

            return ASMTypes;
        }
        /// <summary>
        /// ASMMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AsmMaster>> GetASMLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<AsmMaster>(SQLConstants.ASMMasterLookUp);
                return lookUpLists;
            });
        }
        public IEnumerable<Gender> GetGenderTypes()
        {
            var Gender = new List<Gender>();
            Gender.Add(new Gender() { Text = "Male", Value = "Male" });
            Gender.Add(new Gender() { Text = "Female", Value = "Female" });

            return Gender;
        }
        /// <summary>
        /// ASMMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AgentTypeMaster>> GetAgentTypeLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<AgentTypeMaster>(SQLConstants.AgentTypeMasterLookUp);
                return lookUpLists;
            });
        }

        public IEnumerable<MartialStatus> GetMartialStatus()
        {
            var MartialStatus = new List<MartialStatus>();
            MartialStatus.Add(new MartialStatus() { Text = "Single", Value = "Single" });
            MartialStatus.Add(new MartialStatus() { Text = "Married", Value = "Married" });
            MartialStatus.Add(new MartialStatus() { Text = "Divorced", Value = "Divorced" });
            MartialStatus.Add(new MartialStatus() { Text = "Widow", Value = "Widow" });

            return MartialStatus;
        }
    }
}
