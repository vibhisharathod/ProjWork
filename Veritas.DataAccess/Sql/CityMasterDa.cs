using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
    public class CityMasterDA : BaseRepository, ICityMasterDA
    {
        public async Task AddCityMaster(CityMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(CityIndex) FROM CityMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.CityIndex = 1;
            }
            else
            {
                prodData.CityIndex = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertCityMaster, prodData);
            });
        }

        public async Task<CityMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<CityMaster>(SQLConstants.GetAllCityMasterQuery);
                return companylist;
            });

            //Get CountryMaster based on ID
            var prodFound = prodList.Where(e => e.CityIndex == id).FirstOrDefault<CityMaster>();
            return prodFound;
        }

        public async Task<IEnumerable<CityMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<CityMaster>(SQLConstants.GetAllCityMasterQuery);
                return companylist;
            });
        }

        public async Task<IEnumerable<CityMasterViewModel>> GetAllCityMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<CityMasterViewModel>(SQLConstants.GetCityMasterViewModelQuery);
                return companylist;
            });
        }
    }
}
