using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class MainAgentMasterController : Controller
    {
        // GET: MainAgentMaster
        private readonly IMainAgentMasterDA MainAgentMasterDA;

        public MainAgentMasterController(IMainAgentMasterDA MainAgent)
        {
            MainAgentMasterDA = MainAgent;
        }

        public async Task<ActionResult> Index()
        {
            var result = await MainAgentMasterDA.GetAllMainAgentMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await MainAgentMasterDA.Find(Id);
            return View(selectProd);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}