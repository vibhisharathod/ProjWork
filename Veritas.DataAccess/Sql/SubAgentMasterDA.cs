using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
   public class SubAgentMasterDA : BaseRepository, ISubAgentMasterDA
    {
        public async Task AddSubAgentMaster(SubAgentMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(SubAgent_ID) FROM SubAgentMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.SubAgent_ID = 1;
            }
            else
            {
                prodData.SubAgent_ID = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertSubAgentMaster, prodData);
            });
        }

        public async Task<SubAgentMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<SubAgentMaster>(SQLConstants.GetAllSubAgentMastersQuery);
                return companylist;
            });

            //Get SubAgentMaster based on ID
            var prodFound = prodList.Where(e => e.SubAgent_ID == id).FirstOrDefault<SubAgentMaster>();
            return prodFound;
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
