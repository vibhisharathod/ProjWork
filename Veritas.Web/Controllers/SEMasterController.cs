using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class SEMasterController : Controller
    {
        // GET: SEMaster
        private readonly ISeMasterDA SEDA;

        public SEMasterController(ISeMasterDA SEMasterDA)
        {
            SEDA = SEMasterDA;
        }

        public async Task<ActionResult> Index()
        {
            var result = await SEDA.GetAllSeMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await SEDA.Find(Id);
            return View(selectProd);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}