using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;

namespace Veritas.DataAccess.Sql
{
   public class CountryMasterDA : BaseRepository, ICountryMasterDA
    {
        public Task<CountryMaster> Find(int id)
        {
            throw new NotImplementedException();
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
