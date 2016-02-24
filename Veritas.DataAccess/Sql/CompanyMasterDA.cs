using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
   public class CompanyMasterDA : BaseRepository, ICompanyMasterDA
    {
        public async Task AddCompanyMaster(GiCompanyMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(GICompanyIndex) FROM GI_CompanyMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.GICompanyIndex = 1;
            }
            else
            {
                prodData.GICompanyIndex = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertGiCompanyMaster, prodData);
            });
        }

        public async Task<GiCompanyMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<GiCompanyMaster>(SQLConstants.GetAllCompanyMasterQuery);
                return companylist;
            });

            //Get DivisionMaster based on ID
            var prodFound = prodList.Where(e => e.GICompanyIndex == id).FirstOrDefault<GiCompanyMaster>();
            return prodFound;
        }
        public async Task<IEnumerable<GiCompanyMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<GiCompanyMaster>(SQLConstants.GetAllCompanyMasterQuery);
                return companylist;
            });
        }

        public async Task<IEnumerable<GiCompanyMasterViewModel>> GetAllCompanyMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<GiCompanyMasterViewModel>(SQLConstants.GetCompanyMasterViewModelQuery);
                return companylist;
            });
        }

    }
  
}
