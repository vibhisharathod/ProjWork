using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;

namespace Veritas.DataAccess.Sql
{
   public class AsmMasterDA : BaseRepository, IAsmMasterDA
    {
        public Task<AsmMaster> Find(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<AsmMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<AsmMaster>(SQLConstants.GetAllAsmMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<AsmMasterViewModel>> GetAllAsmMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<AsmMasterViewModel>(SQLConstants.GetAsmMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
