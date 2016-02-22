using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class AreaMasterController : Controller
    {
        // GET: AreaMaster
        public async Task<ActionResult> Index()
        {
            IAreaMasterDA test = new AreaMasterDA();
            var result = await test.GetAllAreaMasterForViews();

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