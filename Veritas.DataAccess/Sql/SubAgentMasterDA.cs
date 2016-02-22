using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;


namespace Veritas.DataAccess.Sql
{
   public class SubAgentMasterDA : BaseRepository, ISubAgentMasterDA
    {
        public Task<SubAgentMaster> Find(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<SubAgentMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<SubAgentMaster>(SQLConstants.GetAllSubAgentMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<SubAgentMasterViewModel>> GetAllSubAgentMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<SubAgentMasterViewModel>(SQLConstants.GetSubAgentMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
