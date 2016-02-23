using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veritas.Entities;

namespace Veritas.DataAccess
{
   public interface ICountryMasterDA
    {
        Task<IEnumerable<CountryMaster>> GetAll();
        Task<IEnumerable<CountryMasterViewModel>> GetAllCountryMasterForViews();
        Task<CountryMaster> Find(int id);
        Task AddCountryMaster(CountryMaster countData);
    }
}
