using System.Net;
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

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await giProductMasterDA.Find(Id);
            return View(selectProd);
        }

        public ActionResult Create()
        {
            return View();
        }        
    }
}