using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
    public interface IAgentTypeMasterDA
    {
        Task<IEnumerable<AgentTypeMaster>> GetAll();
        Task<IEnumerable<AgentTypeMasterViewModel>> GetAllAgentTypeMasterForViews();
        Task<AgentTypeMaster> Find(int id);
    }
}
