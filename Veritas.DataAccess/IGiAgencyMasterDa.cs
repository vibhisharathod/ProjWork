using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;



namespace Veritas.DataAccess
{
   public interface IGiAgencyMasterDA
    {
        Task<IEnumerable<GiAgencyMaster>> GetAll();
        Task<IEnumerable<GiAgencyMasterViewModel>> GetAllGiAgencyMasterForViews();
        Task<GiAgencyMaster> Find(int id);
    }
}
