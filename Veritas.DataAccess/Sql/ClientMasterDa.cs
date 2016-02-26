using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
   public class ClientMasterDA :BaseRepository, IClientMasterDA
    {
        public async Task AddClientMaster(InClientleMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(ClientleIndex) FROM IN_ClientleMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.ClientleIndex = 1;
            }
            else
            {
                prodData.ClientleIndex = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertInClientleMaster, prodData);
            });
        }

        public async Task<InClientleMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<InClientleMaster>(SQLConstants.GetAllInClientleMastersQuery);
                return companylist;
            });

            //Get CountryMaster based on ID
            var prodFound = prodList.Where(e => e.ClientleIndex == id).FirstOrDefault<InClientleMaster>();
            return prodFound;
        }
        public async Task<IEnumerable<InClientleMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<InClientleMaster>(SQLConstants.GetAllInClientleMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<InClientleMasterViewModel>> GetAllInClientleMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<InClientleMasterViewModel>(SQLConstants.GetInClientleMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
