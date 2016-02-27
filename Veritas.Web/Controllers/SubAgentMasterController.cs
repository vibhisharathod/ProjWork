using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class SubAgentMasterController : Controller
    {
        // GET: SubAgentMaster
        private readonly ISubAgentMasterDA subAgentDA;

        public SubAgentMasterController(ISubAgentMasterDA subAgent)
        {
            subAgentDA = subAgent;
        }

        public async Task<ActionResult> Index()
        {
            var result = await subAgentDA.GetAllSubAgentMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await subAgentDA.Find(Id);
            return View(selectProd);
        }


        public ActionResult Create()
        {
            return View();
        }
    }
}