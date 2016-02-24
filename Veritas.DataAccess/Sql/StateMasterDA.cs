using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
   public class StateMasterDA : BaseRepository, IStateMasterDA
    {
        public async Task AddStateMaster(StateMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(StateIndex) FROM StateMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.StateIndex = 1;
            }
            else
            {
                prodData.StateIndex = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertStateMaster, prodData);
            });
        }

        public async Task<StateMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<StateMaster>(SQLConstants.GetAllStateMasterQuery);
                return companylist;
            });

            //Get CountryMaster based on ID
            var prodFound = prodList.Where(e => e.StateIndex == id).FirstOrDefault<StateMaster>();
            return prodFound;
        }

        public async Task<IEnumerable<StateMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<StateMaster>(SQLConstants.GetAllStateMasterQuery);
                return companylist;
            });
        }

        public async Task<IEnumerable<StateMasterViewModel>> GetAllStateMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<StateMasterViewModel>(SQLConstants.GetStateMasterViewModelQuery);
                return companylist;
            });
        }
    }
}
