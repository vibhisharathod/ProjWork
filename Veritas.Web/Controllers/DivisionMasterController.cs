using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class DivisionMasterController : Controller
    {
        // GET: DivisionMaster
        private readonly IDivisionMasterDA DivisionDA;

        public DivisionMasterController(IDivisionMasterDA DivisionMasterDA)
        {
            DivisionDA = DivisionMasterDA;
        }

        public async Task<ActionResult> Index()
        {
            var result = await DivisionDA.GetAllDivisionMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await DivisionDA.Find(Id);
            return View(selectProd);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}