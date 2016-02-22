using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;

namespace Veritas.DataAccess.Sql
{
    public class CityMasterDA : BaseRepository, ICityMasterDA
    {
        public Task<CityMaster> Find(int id)
        {
            throw new NotImplementedException();
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
