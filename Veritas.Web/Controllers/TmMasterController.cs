using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class TmMasterController : Controller
    {
        // GET: TmMaster
        public async Task<ActionResult> Index()
        {
            ITmMasterDA CountryDA = new TmMasterDA();
            var result = await CountryDA.GetAllTmMasterForViews();

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