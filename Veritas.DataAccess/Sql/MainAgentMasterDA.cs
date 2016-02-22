using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;

namespace Veritas.DataAccess.Sql
{
    public class MainAgentMasterDA : BaseRepository, IMainAgentMasterDA
    {
        public Task<MainAgentMaster> Find(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<MainAgentMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<MainAgentMaster>(SQLConstants.GetAllMainAgentMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<MainAgentMasterViewModel>> GetAllMainAgentMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<MainAgentMasterViewModel>(SQLConstants.GetMainAgentMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}