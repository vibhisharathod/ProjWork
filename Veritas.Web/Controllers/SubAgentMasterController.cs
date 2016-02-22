using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class SubAgentMasterController : Controller
    {
        // GET: SubAgentMaster
        public async Task<ActionResult> Index()
        {
            ISubAgentMasterDA test = new SubAgentMasterDA();
            var result = await test.GetAllSubAgentMasterForViews();

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