using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class AgencyMasterController : Controller
    {
        // GET: AgencyMaster
        public async Task<ActionResult> Index()
        {
            IGiAgencyMasterDA test = new GiAgencyMasterDA();
            var result = await test.GetAllGiAgencyMasterForViews();

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