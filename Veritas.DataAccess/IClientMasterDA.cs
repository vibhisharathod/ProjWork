using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
   public interface IClientMasterDA
    {
        Task<IEnumerable<InClientleMaster>> GetAll();
        Task<IEnumerable<InClientleMasterViewModel>> GetAllInClientleMasterForViews();
        Task<InClientleMaster> Find(int id);
    }
}
