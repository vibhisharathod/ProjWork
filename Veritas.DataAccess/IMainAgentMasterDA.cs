using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess.Sql
{
   public interface IMainAgentMasterDA
    {
        Task<IEnumerable<MainAgentMaster>> GetAll();
        Task<IEnumerable<MainAgentMasterViewModel>> GetAllMainAgentMasterForViews();
        Task<MainAgentMaster> Find(int id);
        Task AddMainAgentMaster(MainAgentMaster AreaData);
    }
}
