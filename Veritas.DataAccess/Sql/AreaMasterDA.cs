using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
   public class AreaMasterDA :BaseRepository , IAreaMasterDA
    {
        public async Task AddAreaMaster(AreaMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(AreaIndex) FROM AreaMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.AreaIndex = 1;
            }
            else
            {
                prodData.AreaIndex = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertAreaMaster, prodData);
            });
        }

        public async Task<AreaMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<AreaMaster>(SQLConstants.GetAllAreaMasterQuery);
                return companylist;
            });

            //Get DivisionMaster based on ID
            var prodFound = prodList.Where(e => e.AreaIndex == id).FirstOrDefault<AreaMaster>();
            return prodFound;
        }
        public async Task<IEnumerable<AreaMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<AreaMaster>(SQLConstants.GetAllAreaMasterQuery);
                return insurelist;
            });
        }
        public async Task<IEnumerable<AreaMasterViewModel>> GetAllAreaMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<AreaMasterViewModel>(SQLConstants.GetAreaMasterViewModelQuery);
                return companylist;
            });
        }
    }
}
