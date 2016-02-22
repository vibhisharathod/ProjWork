using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;

namespace Veritas.DataAccess.Sql
{
   public class DivisionMasterDA : BaseRepository, IDivisionMasterDA
    {
        public Task<DivisionMaster> Find(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<DivisionMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<DivisionMaster>(SQLConstants.GetAllDivisionMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<DivisionMasterViewModel>> GetAllDivisionMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<DivisionMasterViewModel>(SQLConstants.GetDivisionMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
