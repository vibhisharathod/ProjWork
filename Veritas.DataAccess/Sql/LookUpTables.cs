using System;
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

        /// <summary>
        /// GI_ProductMaster
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<GiProductMaster>> GetProductLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<GiProductMaster>(SQLConstants.GIProductTypeMasterLookUp);
                return lookUpLists;
            });
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

        public IEnumerable<VerticalTypes> GetVerticalTypes()
        {
            var VerticalTypes = new List<VerticalTypes>();
            VerticalTypes.Add(new VerticalTypes() { Text = "Direct", Value = "Direct" });
            VerticalTypes.Add(new VerticalTypes() { Text = "In-Direct", Value = "In-Direct" });

            return VerticalTypes;
        }

        public async Task<IEnumerable<CityMaster>> GetCityLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<CityMaster>(SQLConstants.CityMasterLookUp);
                return lookUpLists;
            });
        }

        public async Task<IEnumerable<StateMaster>> GetStateLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<StateMaster>(SQLConstants.StateMasterLookUp);
                return lookUpLists;
            });
        }

        public async Task<IEnumerable<CountryMaster>> GetCountryLookUp()
        {
            return await WithConnection(async c =>
            {
                var lookUpLists = await c.QueryAsync<CountryMaster>(SQLConstants.CountryMasterLookUp);
                return lookUpLists;
            });
        }
    }
}
