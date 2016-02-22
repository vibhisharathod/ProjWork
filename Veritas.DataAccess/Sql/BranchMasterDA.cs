using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;

namespace Veritas.DataAccess.Sql
{
   public class BranchMasterDA :BaseRepository, IBranchMasterDA
    {
        public Task<BranchMaster> Find(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<BranchMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<BranchMaster>(SQLConstants.GetAllBranchMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<BranchMasterViewModel>> GetAllBranchMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<BranchMasterViewModel>(SQLConstants.GetBranchMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
