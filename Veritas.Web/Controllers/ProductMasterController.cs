using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;
using Veritas.Entities;

namespace Veritas.Web.Controllers
{
    public class ProductMasterController : Controller
    {
        // GET: ProductMaster
        public async Task<ActionResult> Index()
        {
            IProductMasterDA insureDA = new GiProductMasterDA();
            var result = await insureDA.GetAllProductMasterForViews();

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

        [HttpPost]
        public ActionResult Create(GiProductMaster prodData)
        {
            return View();
        }
    }
}