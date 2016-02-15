using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
    public interface IInsureMasterDA
    {
        Task<IEnumerable<GiInsureMaster>> GetAll();
        Task<IEnumerable<GiInsureMasterViewModel>> GetAllInsureMasterForViews();
        Task<GiInsureMaster> Find(int? id);
        //GiInsureMaster Add(GiInsureMaster employee);
        //GiInsureMaster Update(GiInsureMaster employee);
        //void Remove(int id);
    }
}
