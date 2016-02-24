using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
    public class MainAgentMasterDA : BaseRepository, IMainAgentMasterDA
    {
        public async Task AddMainAgentMaster(MainAgentMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(MainAgent_ID) FROM MainAgentMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.MainAgent_ID = 1;
            }
            else
            {
                prodData.MainAgent_ID = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertMainAgentMaster, prodData);
            });
        }

        public async Task<MainAgentMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<MainAgentMaster>(SQLConstants.GetAllMainAgentMastersQuery);
                return companylist;
            });

            //Get DivisionMaster based on ID
            var prodFound = prodList.Where(e => e.MainAgent_ID == id).FirstOrDefault<MainAgentMaster>();
            return prodFound;
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