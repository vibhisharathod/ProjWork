using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
   public class AgentTypeMasterDA : BaseRepository, IAgentTypeMasterDA
    {
        public async Task AddAgentTypeMaster(AgentTypeMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(AgentTypeID) FROM AgentTypeMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.AgentTypeID = 1;
            }
            else
            {
                prodData.AgentTypeID = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertAgentTypeMaster, prodData);
            });
        }

        public async Task<AgentTypeMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<AgentTypeMaster>(SQLConstants.GetAllAgentTypeMastersQuery);
                return companylist;
            });

            //Get AgentTypeMaster based on ID
            var prodFound = prodList.Where(e => e.AgentTypeID == id).FirstOrDefault<AgentTypeMaster>();
            return prodFound;
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
