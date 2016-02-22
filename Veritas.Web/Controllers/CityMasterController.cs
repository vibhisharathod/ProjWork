using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class CityMasterController : Controller
    {
        // GET: CityMaster
        public async Task<ActionResult> Index()
        {
            ICityMasterDA CountryDA = new CityMasterDA();
            var result = await CountryDA.GetAllCityMasterForViews();

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