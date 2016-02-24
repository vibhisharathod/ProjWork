using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;


namespace Veritas.DataAccess
{
   public interface ICityMasterDA
    {
        Task<IEnumerable<CityMaster>> GetAll();
        Task<IEnumerable<CityMasterViewModel>> GetAllCityMasterForViews();
        Task<CityMaster> Find(int id);
        Task AddCityMaster(CityMaster countData);
    }
}
