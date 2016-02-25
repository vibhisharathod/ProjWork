using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class BranchMasterController : Controller
    {
        // GET: BranchMaster
        private readonly IBranchMasterDA BranchDA;

        public BranchMasterController(IBranchMasterDA BranchMasterDA)
        {
            BranchDA = BranchMasterDA;
        }

        public async Task<ActionResult> Index()
        {
            var result = await BranchDA.GetAllBranchMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await BranchDA.Find(Id);
            return View(selectProd);
        }
        public ActionResult Create()
        {
            return View();
        }
       
        public async Task<ActionResult> Edit(int Id)
        {
            var selectProd = await BranchDA.Find(Id);
            return View(selectProd);
        }
        public async Task<ActionResult> Delete(int Id)
        {
            var selectProd = await BranchDA.Find(Id);
            return View(selectProd);
        }
    }
}