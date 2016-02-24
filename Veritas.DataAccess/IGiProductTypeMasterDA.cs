using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
    public interface IGiProductTypeMasterDA
    {
        Task<IEnumerable<GiProductTypeMaster>> GetAll();
        Task<IEnumerable<GiProductTypeMasterViewModel>> GetAllProductTypeMasterForViews();
        Task<GiProductTypeMaster> Find(int id);
        Task AddProductTypeMaster(GiProductTypeMaster DivData);
    }
}
