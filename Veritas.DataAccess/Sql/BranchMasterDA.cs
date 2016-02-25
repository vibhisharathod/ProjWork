using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
   public class BranchMasterDA :BaseRepository, IBranchMasterDA
    {
        public async Task AddBranchMaster(BranchMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(Branch_ID) FROM BranchMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.Branch_ID = 1;
            }
            else
            {
                prodData.Branch_ID = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertBranchMaster, prodData);
            });
        }

        public async Task EditBranchMaster(BranchMaster prodData)
        {
          
            //Filling Other Records like User Id, Creation & Update Date
        
            prodData.UpdateUserIndex = 1; //Later Logged in User           
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.UpdateBranchMaster, prodData);
            });
        }
        public async Task DeleteBranchMaster(BranchMaster prodData)
        {

            //Filling Other Records like User Id, Creation & Update Date

            prodData.UpdateUserIndex = 1; //Later Logged in User           
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.DeleteBranchMaster, prodData);
            });
        }
        public async Task<BranchMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<BranchMaster>(SQLConstants.GetAllBranchMastersQuery);
                return companylist;
            });

            //Get DivisionMaster based on ID
            var prodFound = prodList.Where(e => e.Branch_ID == id).FirstOrDefault<BranchMaster>();
            return prodFound;
        }
        public async Task<IEnumerable<BranchMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<BranchMaster>(SQLConstants.GetAllBranchMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<BranchMasterViewModel>> GetAllBranchMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<BranchMasterViewModel>(SQLConstants.GetBranchMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
