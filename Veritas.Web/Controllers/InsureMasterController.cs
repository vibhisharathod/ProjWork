using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;

namespace Veritas.Web.Controllers
{
    public class InsureMasterController : Controller
    {
        private readonly IInsureMasterDA insureDA;

        public InsureMasterController(IInsureMasterDA insureMasterDA)
        {
            insureDA = insureMasterDA;
        }
        
        public async Task<ActionResult> Index()
        {            
            var result = await insureDA.GetAllInsureMasterForViews();

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