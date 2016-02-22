using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
   public interface IAreaMasterDA
    {
        Task<IEnumerable<AreaMaster>> GetAll();
        Task<IEnumerable<AreaMasterViewModel>> GetAllAreaMasterForViews();
        Task<AreaMaster> Find(int? id);
    }
}
