using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
   public interface IBranchMasterDA
    {
        Task<IEnumerable<BranchMaster>> GetAll();
        Task<IEnumerable<BranchMasterViewModel>> GetAllBranchMasterForViews();
        Task<BranchMaster> Find(int id);
        Task AddBranchMaster(BranchMaster AgentTypeData);
    }
}
