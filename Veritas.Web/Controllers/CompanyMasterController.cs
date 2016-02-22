using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class CompanyMasterController : Controller
    {
        // GET: CompanyMaster
       
        //private readonly ICompanyMasterDA insureDA;

        //public CompanyMasterController(ICompanyMasterDA insureMasterDA)
        //{
        //    insureDA = insureMasterDA;
        //}

        public async Task<ActionResult> Index()
        {
            ICompanyMasterDA insureDA = new CompanyMasterDA();
            var result = await insureDA.GetAllCompanyMasterForViews();

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