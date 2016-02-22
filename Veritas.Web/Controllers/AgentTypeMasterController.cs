using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class AgentTypeMasterController : Controller
    {
        // GET: AgentTypeMaster
        public async Task<ActionResult> Index()
        {
            IAgentTypeMasterDA test = new AgentTypeMasterDA();
            var result = await test.GetAllAgentTypeMasterForViews();

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