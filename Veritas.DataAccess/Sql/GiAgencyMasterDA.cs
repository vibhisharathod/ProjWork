using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;


namespace Veritas.DataAccess.Sql
{
    public class GiAgencyMasterDA : BaseRepository, IGiAgencyMasterDA
    {
        public Task<GiAgencyMaster> Find(int id)
        {
            throw new NotImplementedException();
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
