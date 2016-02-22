using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;

namespace Veritas.DataAccess.Sql
{
   public class CompanyMasterDA : BaseRepository, ICompanyMasterDA
    {
        public Task<GiCompanyMaster> Find(int? id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<GiCompanyMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<GiCompanyMaster>(SQLConstants.GetAllCompanyMasterQuery);
                return companylist;
            });
        }

        public async Task<IEnumerable<GiCompanyMasterViewModel>> GetAllCompanyMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<GiCompanyMasterViewModel>(SQLConstants.GetCompanyMasterViewModelQuery);
                return companylist;
            });
        }

    }
  
}
