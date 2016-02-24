using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;
using Dapper;
using System.Linq;

namespace Veritas.DataAccess.Sql
{
   public class AsmMasterDA : BaseRepository, IAsmMasterDA
    {
        public async Task AddASMMaster(AsmMaster prodData)
        {
            var maxId = await WithConnection(async c =>
            {
                return await c.QueryAsync<int>("SELECT max(ASMIndex) FROM AsmMaster");
            });

            //Setting Primary Key
            if (maxId.SingleOrDefault() == 0)
            {
                prodData.ASMIndex = 1;
            }
            else
            {
                prodData.ASMIndex = maxId.SingleOrDefault() + 1;
            }

            //Filling Other Records like User Id, Creation & Update Date
            prodData.CreateUserIndex = 1; //Later Logged in User
            prodData.UpdateUserIndex = 1; //Later Logged in User
            prodData.CreateDateTime = DateTime.Now;
            prodData.UpdateDateTime = DateTime.Now;

            await WithConnection(async c =>
            {
                return await c.QueryAsync<int>(SQLConstants.InsertASMMaster, prodData);
            });
        }

        public async Task<AsmMaster> Find(int id)
        {
            var prodList = await WithConnection(async c =>
            {
                var companylist = await c.QueryAsync<AsmMaster>(SQLConstants.GetAllAsmMastersQuery);
                return companylist;
            });

            //Get DivisionMaster based on ID
            var prodFound = prodList.Where(e => e.ASMIndex == id).FirstOrDefault<AsmMaster>();
            return prodFound;
        }
        public async Task<IEnumerable<AsmMaster>> GetAll()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<AsmMaster>(SQLConstants.GetAllAsmMastersQuery);
                return insurelist;
            });
        }

        public async Task<IEnumerable<AsmMasterViewModel>> GetAllAsmMasterForViews()
        {
            return await WithConnection(async c =>
            {
                var insurelist = await c.QueryAsync<AsmMasterViewModel>(SQLConstants.GetAsmMasterViewModelQuery);
                return insurelist;
            });
        }
    }
}
