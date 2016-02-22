using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class MainAgentMasterController : Controller
    {
        // GET: MainAgentMaster
        public async Task<ActionResult> Index()
        {
            IMainAgentMasterDA test = new MainAgentMasterDA();
            var result = await test.GetAllMainAgentMasterForViews();

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