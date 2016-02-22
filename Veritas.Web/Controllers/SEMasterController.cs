using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class SEMasterController : Controller
    {
        // GET: SEMaster
        public async Task<ActionResult> Index()
        {
            ISeMasterDA CountryDA = new SeMasterDA();
            var result = await CountryDA.GetAllSeMasterForViews();

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