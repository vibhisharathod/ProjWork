using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;

namespace Veritas.DataAccess.Sql
{
   public class ClientMasterDA :BaseRepository, IClientMasterDA
    {
        public Task<InClientleMaster> Find(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<InClientleMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<InClientleMaster>(SQLConstants.GetAllInClientleMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<InClientleMasterViewModel>> GetAllInClientleMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<InClientleMasterViewModel>(SQLConstants.GetInClientleMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
