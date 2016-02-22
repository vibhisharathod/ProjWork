using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;
using Veritas.Entities;

namespace Veritas.Web.Controllers
{
    public class ProductMasterController : Controller
    {
        private readonly IProductMasterDA giProductMasterDA;
        public ProductMasterController(IProductMasterDA GiProductMaster)
        {
            giProductMasterDA = GiProductMaster;
        }

        // GET: ProductMaster
        public async Task<ActionResult> Index()
        {
            
            var result = await giProductMasterDA.GetAllProductMasterForViews();

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
        public async Task<ActionResult> Create(GiProductMaster prodData)
        {
            if (prodData != null)
            {
                await giProductMasterDA.AddProductMaster(prodData);
                //Testing
            }
            return RedirectToAction("Index", "ProductMaster");
        }
    }
}