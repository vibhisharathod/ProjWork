using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
   public interface IDivisionMasterDA
    {
        Task<IEnumerable<DivisionMaster>> GetAll();
        Task<IEnumerable<DivisionMasterViewModel>> GetAllDivisionMasterForViews();
        Task<DivisionMaster> Find(int id);
        Task AddDivisionMaster(DivisionMaster DivData);
    }
}
