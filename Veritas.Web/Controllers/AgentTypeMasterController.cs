using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class AgentTypeMasterController : Controller
    {
        // GET: AgentTypeMaster
        private readonly IAgentTypeMasterDA AgentTypeMasterDA;

        public AgentTypeMasterController(IAgentTypeMasterDA DivisionMasterDA)
        {
            AgentTypeMasterDA = DivisionMasterDA;
        }

        public async Task<ActionResult> Index()
        {
            var result = await AgentTypeMasterDA.GetAllAgentTypeMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await AgentTypeMasterDA.Find(Id);
            return View(selectProd);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}