using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess.Sql
{
   public class GiProductTypeMasterDA :BaseRepository, IGiProductTypeMasterDA
    {
        public Task<GiProductTypeMaster> Find(int? id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<GiProductTypeMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<GiProductTypeMaster>(SQLConstants.GetAllProductTypeMasterQuery);
                return companylist;
            });
        }

        public async Task<IEnumerable<GiProductTypeMasterViewModel>> GetAllProductTypeMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<GiProductTypeMasterViewModel>(SQLConstants.GetProductTypeMasterViewModelQuery);
                return companylist;
            });
        }
    }
}
