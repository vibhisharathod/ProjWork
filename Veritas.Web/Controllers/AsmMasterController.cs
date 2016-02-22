using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class AsmMasterController : Controller
    {
        // GET: AsmMaster
        public async Task<ActionResult> Index()
        {
            IAsmMasterDA test = new AsmMasterDA();
            var result = await test.GetAllAsmMasterForViews();

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