﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
    public interface ILookUpTables
    {
        Task<IEnumerable<GiCompanyMaster>> GetCompanyLookUp();
        Task<IEnumerable<GiProductTypeMaster>> GetTypeLookUp();
        Task<IEnumerable<AgentTypeMaster>> GetAgentTypeLookUp();
        Task<IEnumerable<TmMaster>> GetTMLookUp();
        Task<IEnumerable<SeMaster>> GetSELookUp();
        Task<IEnumerable<AsmMaster>> GetASMLookUp();
        Task<IEnumerable<InClientleMaster>> GetClientLookUp();
        Task<IEnumerable<GiAgencyMaster>> GetAgencyLookUp();
        Task<IEnumerable<MainAgentMaster>> GetMALookUp();
        Task<IEnumerable<SubAgentMaster>> GetSALookUp();
        Task<IEnumerable<BranchMaster>> GetBranchLookUp();
        Task<IEnumerable<GiProductMaster>> GetProductLookUp();
        Task<IEnumerable<AreaMaster>> GetAreaLookUp();
        Task<IEnumerable<CityMaster>> GetCityLookUp();
        Task<IEnumerable<StateMaster>> GetStateLookUp();
        Task<IEnumerable<CountryMaster>> GetCountryLookUp();
        Task<IEnumerable<DivisionMaster>> GetDivisionLookUp();

        IEnumerable<PolicyStatus> GetPolicyStatus();
        IEnumerable<BusinessStatus> GetBusinessStatus();
        IEnumerable<ProductSubTypes> GetProductSubTypes();
        IEnumerable<PaymentTypes> GetPaymentTypes();
        IEnumerable<ClaimProcessTypes> ClaimProcessTypes();
        IEnumerable<VerticalTypes> GetVerticalTypes();
        IEnumerable<ACType> GetACTypes();
        IEnumerable<BranchType> GetBranchTypes();
        IEnumerable<ASMTypes> GetASMTypes();
        IEnumerable<Gender> GetGenderTypes();
        IEnumerable<MartialStatus> GetMartialStatus();
    }
}
