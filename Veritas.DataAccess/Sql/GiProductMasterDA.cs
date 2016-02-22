using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
   public class GiProductMasterDA : BaseRepository, IProductMasterDA
    {
        public async Task AddProductMaster(GiProductMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(GIProductIndex) FROM GI_ProductMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.GIProductIndex = 1;
            }
            else
            {
                prodData.GIProductIndex = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertProductMaster, prodData);
            });
        }

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
