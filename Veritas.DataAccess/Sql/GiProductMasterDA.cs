using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;

namespace Veritas.DataAccess.Sql
{
   public class GiProductMasterDA : BaseRepository, IProductMasterDA
    {
        public Task<GiProductMaster> Find(int? id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<GiProductMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<GiProductMaster>(SQLConstants.GetAllProductMasterQuery);
                return companylist;
            });
        }

        public async Task<IEnumerable<GiProductMasterViewModel>> GetAllProductMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<GiProductMasterViewModel>(SQLConstants.GetProductMasterViewModelQuery);
                return companylist;
            });
        }
    }
}
