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
        private readonly IAsmMasterDA ASMDA;

        public AsmMasterController(IAsmMasterDA ASMMasterDA)
        {
            ASMDA = ASMMasterDA;
        }

        public async Task<ActionResult> Index()
        {
            var result = await ASMDA.GetAllAsmMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await ASMDA.Find(Id);
            return View(selectProd);
        }


        public ActionResult Create()
        {
            return View();
        }
    }
}