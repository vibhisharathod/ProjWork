using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
   public class DivisionMasterDA : BaseRepository, IDivisionMasterDA
    {
        public async Task AddDivisionMaster(DivisionMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(DivisionIndex) FROM DivisionMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.DivisionIndex = 1;
            }
            else
            {
                prodData.DivisionIndex = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertDivisionMaster, prodData);
            });
        }

        public async Task<DivisionMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<DivisionMaster>(SQLConstants.GetAllDivisionMastersQuery);
                return companylist;
            });

            //Get DivisionMaster based on ID
            var prodFound = prodList.Where(e => e.DivisionIndex == id).FirstOrDefault<DivisionMaster>();
            return prodFound;
        }
        public async Task<IEnumerable<DivisionMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<DivisionMaster>(SQLConstants.GetAllDivisionMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<DivisionMasterViewModel>> GetAllDivisionMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<DivisionMasterViewModel>(SQLConstants.GetDivisionMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
