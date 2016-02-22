using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class BranchMasterController : Controller
    {
        // GET: BranchMaster
        public async Task<ActionResult> Index()
        {
            IBranchMasterDA test = new BranchMasterDA();
            var result = await test.GetAllBranchMasterForViews();

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