using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class StateMasterController : Controller
    {
        // GET: State
        public async Task<ActionResult> Index()
        {
            IStateMasterDA test = new StateMasterDA();
            var result = await test.GetAllStateMasterForViews();

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