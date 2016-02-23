using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
   public class CountryMasterDA : BaseRepository, ICountryMasterDA
    {
        public async Task AddCountryMaster(CountryMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(CountryIndex) FROM CountryMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.CountryIndex = 1;
            }
            else
            {
                prodData.CountryIndex = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertCountryMaster, prodData);
            });
        }

        public async Task<CountryMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<CountryMaster>(SQLConstants.GetAllCountryMastersQuery);
                return companylist;
            });

            //Get CountryMaster based on ID
            var prodFound = prodList.Where(e => e.CountryIndex == id).FirstOrDefault<CountryMaster>();
            return prodFound;
        }
        public async Task<IEnumerable<CountryMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<CountryMaster>(SQLConstants.GetAllCountryMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<CountryMasterViewModel>> GetAllCountryMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<CountryMasterViewModel>(SQLConstants.GetCountryMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
