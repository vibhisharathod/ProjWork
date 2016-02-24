using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class CompanyMasterController : Controller
    {
        // GET: CompanyMaster

        private readonly ICompanyMasterDA insureDA;

        public CompanyMasterController(ICompanyMasterDA insureMasterDA)
        {
            insureDA = insureMasterDA;
        }

        public async Task<ActionResult> Index()
        {
           
            var result = await insureDA.GetAllCompanyMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await insureDA.Find(Id);
            return View(selectProd);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}