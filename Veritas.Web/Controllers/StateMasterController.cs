using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class StateMasterController : Controller
    {
        // GET: State
        private readonly IStateMasterDA stateDA;

        public StateMasterController(IStateMasterDA stateMasterDA)
        {
            stateDA = stateMasterDA;
        }

        public async Task<ActionResult> Index()
        {
            var result = await stateDA.GetAllStateMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await stateDA.Find(Id);
            return View(selectProd);
        }


        public ActionResult Create()
        {
            return View();
        }
    }
}