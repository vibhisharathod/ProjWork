using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
   public interface ITmMasterDA
    {
        Task<IEnumerable<TmMaster>> GetAll();
        Task<IEnumerable<TmMasterViewModel>> GetAllTmMasterForViews();
        Task<TmMaster> Find(int id);
    }
}
