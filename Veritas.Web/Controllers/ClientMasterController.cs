using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class ClientMasterController : Controller
    {
        // GET: ClientMaster
        public async Task<ActionResult> Index()
        {
            IClientMasterDA test = new ClientMasterDA();
            var result = await test.GetAllInClientleMasterForViews();

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