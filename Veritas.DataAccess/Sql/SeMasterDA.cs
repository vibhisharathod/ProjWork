using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
   public class SeMasterDA :BaseRepository, ISeMasterDA
    {
        public async Task AddSEMaster(SeMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(SE_ID) FROM SEMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.SE_ID = 1;
            }
            else
            {
                prodData.SE_ID = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertSEMaster, prodData);
            });
        }

        public async Task<SeMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<SeMaster>(SQLConstants.GetAllSEMastersQuery);
                return companylist;
            });

            //Get SE based on ID
            var prodFound = prodList.Where(e => e.SE_ID == id).FirstOrDefault<SeMaster>();
            return prodFound;
        }
        public async Task<IEnumerable<SeMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<SeMaster>(SQLConstants.GetAllSEMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<SeMasterViewModel>> GetAllSeMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<SeMasterViewModel>(SQLConstants.GetSEMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
