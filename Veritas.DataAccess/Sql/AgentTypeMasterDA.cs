using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;

namespace Veritas.DataAccess.Sql
{
   public class AgentTypeMasterDA : BaseRepository, IAgentTypeMasterDA
    {
        public Task<AgentTypeMaster> Find(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<AgentTypeMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<AgentTypeMaster>(SQLConstants.GetAllAgentTypeMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<AgentTypeMasterViewModel>> GetAllAgentTypeMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<AgentTypeMasterViewModel>(SQLConstants.GetAgentTypeViewModelQuery);
                return insurelist;
            });
        }
    }
}
