using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class CityMasterController : Controller
    {
        // GET: CityMaster
       
        private readonly ICityMasterDA CityDA;

        public CityMasterController(ICityMasterDA cityMasterDA)
        {
            CityDA = cityMasterDA;
        }

        public async Task<ActionResult> Index()
        {
            var result = await CityDA.GetAllCityMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await CityDA.Find(Id);
            return View(selectProd);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}