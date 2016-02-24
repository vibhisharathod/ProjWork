using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class ProductTypeMasterController : Controller
    {
        // GET: ProductTypeMaster
        private readonly IGiProductTypeMasterDA giProductTypeMasterDA;
        public ProductTypeMasterController(IGiProductTypeMasterDA GiProductMaster)
        {
            giProductTypeMasterDA = GiProductMaster;
        }

      
        public async Task<ActionResult> Index()
        {
            var result = await giProductTypeMasterDA.GetAllProductTypeMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await giProductTypeMasterDA.Find(Id);
            return View(selectProd);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}