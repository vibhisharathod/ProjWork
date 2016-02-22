using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;

namespace Veritas.DataAccess.Sql
{
   public class TmMasterDA :BaseRepository, ITmMasterDA
    {
        public Task<TmMaster> Find(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<TmMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<TmMaster>(SQLConstants.GetAllTmMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<TmMasterViewModel>> GetAllTmMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<TmMasterViewModel>(SQLConstants.GetTmMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
