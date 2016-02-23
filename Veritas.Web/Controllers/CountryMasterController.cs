using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;
using Veritas.Entities;

namespace Veritas.Web.Controllers
{
    public class CountryMasterController : Controller
    {
        // GET: CountryMaster
        private readonly ICountryMasterDA CountryDA;

        public CountryMasterController(ICountryMasterDA insureMasterDA)
        {
            CountryDA = insureMasterDA;
        }

        public async Task<ActionResult> Index()
        {
            var result = await CountryDA.GetAllCountryMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await CountryDA.Find(Id);
            return View(selectProd);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}