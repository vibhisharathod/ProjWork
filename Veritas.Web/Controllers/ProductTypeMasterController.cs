using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class ProductTypeMasterController : Controller
    {
        // GET: ProductTypeMaster
        public async Task<ActionResult> Index()
        {
            IGiProductTypeMasterDA insureDA = new GiProductTypeMasterDA();
            var result = await insureDA.GetAllProductTypeMasterForViews();

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