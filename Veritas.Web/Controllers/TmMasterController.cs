using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class TmMasterController : Controller
    {
        // GET: TmMaster
        private readonly ITmMasterDA TMDA;

        public TmMasterController(ITmMasterDA TmMaster)
        {
            TMDA = TmMaster;
        }

        public async Task<ActionResult> Index()
        {
            var result = await TMDA.GetAllTmMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await TMDA.Find(Id);
            return View(selectProd);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}