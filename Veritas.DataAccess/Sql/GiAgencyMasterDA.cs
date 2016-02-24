using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
    public class GiAgencyMasterDA : BaseRepository, IGiAgencyMasterDA
    {
        public async Task AddGiAgencyMaster(GiAgencyMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(AgencyIndex) FROM GI_AgencyMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.AgencyIndex = 1;
            }
            else
            {
                prodData.AgencyIndex = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertGiAgencyMaster, prodData);
            });
        }

        public async Task<GiAgencyMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<GiAgencyMaster>(SQLConstants.GetAllGiAgencyMastersQuery);
                return companylist;
            });

            //Get DivisionMaster based on ID
            var prodFound = prodList.Where(e => e.AgencyIndex == id).FirstOrDefault<GiAgencyMaster>();
            return prodFound;
        }
        public async Task<IEnumerable<GiAgencyMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<GiAgencyMaster>(SQLConstants.GetAllGiAgencyMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<GiAgencyMasterViewModel>> GetAllGiAgencyMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<GiAgencyMasterViewModel>(SQLConstants.GetGiAgencyMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
