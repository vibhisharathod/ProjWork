﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
    public interface ILookUpTables
    {
        Task<IEnumerable<GiCompanyMaster>> GetCompanyLookUp();
        Task<IEnumerable<GiProductTypeMaster>> GetTypeLookUp();
        Task<IEnumerable<TmMaster>> GetTMLookUp();
        Task<IEnumerable<SeMaster>> GetSELookUp();
        Task<IEnumerable<InClientleMaster>> GetClientLookUp();
        Task<IEnumerable<GiAgencyMaster>> GetAgencyLookUp();
        Task<IEnumerable<MainAgentMaster>> GetMALookUp();
        Task<IEnumerable<BranchMaster>> GetBranchLookUp();
        Task<IEnumerable<GiProductMaster>> GetProductLookUp();

        IEnumerable<PolicyStatus> GetPolicyStatus();
        IEnumerable<BusinessStatus> GetBusinessStatus();
        IEnumerable<ProductSubTypes> GetProductSubTypes();
        IEnumerable<PaymentTypes> GetPaymentTypes();
        IEnumerable<ClaimProcessTypes> ClaimProcessTypes();
        IEnumerable<VerticalTypes> GetVerticalTypes();

    }
}
