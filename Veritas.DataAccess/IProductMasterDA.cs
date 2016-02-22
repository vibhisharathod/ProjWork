using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
   public interface IProductMasterDA
    {
        Task<IEnumerable<GiProductMaster>> GetAll();
        Task<IEnumerable<GiProductMasterViewModel>> GetAllProductMasterForViews();
        Task<GiProductMaster> Find(int? id);
        Task AddProductMaster(GiProductMaster prodData);
    }
}
