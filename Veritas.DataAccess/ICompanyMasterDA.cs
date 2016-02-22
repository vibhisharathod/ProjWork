using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
    public interface ICompanyMasterDA
    {
        Task<IEnumerable<GiCompanyMaster>> GetAll();
        Task<IEnumerable<GiCompanyMasterViewModel>> GetAllCompanyMasterForViews();
        Task<GiCompanyMaster> Find(int? id);
    }
}
