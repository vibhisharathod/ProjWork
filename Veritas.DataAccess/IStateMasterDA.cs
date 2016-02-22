using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
   public interface IStateMasterDA
    {
        Task<IEnumerable<StateMaster>> GetAll();
        Task<IEnumerable<StateMasterViewModel>> GetAllStateMasterForViews();
        Task<StateMaster> Find(int id);
    }
}
