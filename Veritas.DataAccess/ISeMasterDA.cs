using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
   public interface ISeMasterDA
    {
        Task<IEnumerable<SeMaster>> GetAll();
        Task<IEnumerable<SeMasterViewModel>> GetAllSeMasterForViews();
        Task<SeMaster> Find(int id);
        Task AddSEMaster(SeMaster SEData);
    }
}
