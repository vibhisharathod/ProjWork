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
        public async Task AddProductTypeMaster(GiProductTypeMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(GITypeIndex) FROM GI_ProductTypeMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.GITypeIndex = 1;
            }
            else
            {
                prodData.GITypeIndex = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertProductTypeMaster, prodData);
            });
        }

        public async Task<GiProductTypeMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<GiProductTypeMaster>(SQLConstants.GetAllProductTypeMasterQuery);
                return companylist;
            });

            //Get ProductMaster based on ID
            var prodFound = prodList.Where(e => e.GITypeIndex == id).FirstOrDefault<GiProductTypeMaster>();
            return prodFound;
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
