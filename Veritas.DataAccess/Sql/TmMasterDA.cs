using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
   public class TmMasterDA :BaseRepository, ITmMasterDA
    {
        public async Task AddTMMaster(TmMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(TM_ID) FROM TMMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.TM_ID = 1;
            }
            else
            {
                prodData.TM_ID = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertTMMaster, prodData);
            });
        }

        public async Task<TmMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<TmMaster>(SQLConstants.GetAllTmMastersQuery);
                return companylist;
            });

            //Get SE based on ID
            var prodFound = prodList.Where(e => e.TM_ID == id).FirstOrDefault<TmMaster>();
            return prodFound;
        }
        public async Task<IEnumerable<TmMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<TmMaster>(SQLConstants.GetAllTmMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<TmMasterViewModel>> GetAllTmMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<TmMasterViewModel>(SQLConstants.GetTmMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
