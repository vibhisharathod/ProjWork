using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
   public interface IAsmMasterDA
    {
        Task<IEnumerable<AsmMaster>> GetAll();
        Task<IEnumerable<AsmMasterViewModel>> GetAllAsmMasterForViews();
        Task<AsmMaster> Find(int id);
        Task AddASMMaster(AsmMaster ASMData);
    }
}
