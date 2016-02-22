using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;


namespace Veritas.DataAccess.Sql
{
   public class SeMasterDA :BaseRepository, ISeMasterDA
    {
        public Task<SeMaster> Find(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<SeMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<SeMaster>(SQLConstants.GetAllSEMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<SeMasterViewModel>> GetAllSeMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<SeMasterViewModel>(SQLConstants.GetSEMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
