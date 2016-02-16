using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class InsureMasterController : Controller
    {
        // GET: InsureMaster
        public async Task<ActionResult> Index()
        {
            IInsureMasterDA test = new InsureMasterDA();
            var result = await test.GetAllInsureMasterForViews();

            return View(result);
        }

        public ActionResult ViewDetails(string Id)
        {
            return View();
        }
    }
}