using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
   public interface ISubAgentMasterDA
    {
        Task<IEnumerable<SubAgentMaster>> GetAll();
        Task<IEnumerable<SubAgentMasterViewModel>> GetAllSubAgentMasterForViews();
        Task<SubAgentMaster> Find(int id);
    }
}
