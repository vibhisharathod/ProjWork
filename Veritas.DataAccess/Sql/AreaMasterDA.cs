using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;

namespace Veritas.DataAccess.Sql
{
   public class AreaMasterDA :BaseRepository , IAreaMasterDA
    {
        public Task<AreaMaster> Find(int? id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<AreaMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<AreaMaster>(SQLConstants.GetAllAreaMasterQuery);
                return companylist;
            });
        }

        public async Task<IEnumerable<AreaMasterViewModel>> GetAllAreaMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<AreaMasterViewModel>(SQLConstants.GetAreaMasterViewModelQuery);
                return companylist;
            });
        }
    }
}
