using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class AreaMasterController : Controller
    {
        // GET: AreaMaster
        private readonly IAreaMasterDA AreaDA;

        public AreaMasterController(IAreaMasterDA AreaMasterDA)
        {
            AreaDA = AreaMasterDA;
        }

        public async Task<ActionResult> Index()
        {
            var result = await AreaDA.GetAllAreaMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await AreaDA.Find(Id);
            return View(selectProd);
        }


        public ActionResult Create()
        {
            return View();
        }
    }
}