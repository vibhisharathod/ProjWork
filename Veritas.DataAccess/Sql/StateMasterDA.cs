using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;

namespace Veritas.DataAccess.Sql
{
   public class StateMasterDA : BaseRepository, IStateMasterDA
    {
        public Task<StateMaster> Find(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<StateMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<StateMaster>(SQLConstants.GetAllStateMasterQuery);
                return companylist;
            });
        }

        public async Task<IEnumerable<StateMasterViewModel>> GetAllStateMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<StateMasterViewModel>(SQLConstants.GetStateMasterViewModelQuery);
                return companylist;
            });
        }
    }
}
