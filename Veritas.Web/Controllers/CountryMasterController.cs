using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class CountryMasterController : Controller
    {
        // GET: CountryMaster
        //private readonly ICountryMasterDA CountryDA;

        //public CountryMasterController(ICountryMasterDA insureMasterDA)
        //{
        //    CountryDA = insureMasterDA;
        //}

        public async Task<ActionResult> Index()
        {
            ICountryMasterDA CountryDA = new CountryMasterDA();
            var result = await CountryDA.GetAllCountryMasterForViews();

            return View(result);
        }

        public ActionResult ViewDetails(string Id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}