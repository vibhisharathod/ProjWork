using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class AgencyMasterController : Controller
    {
        // GET: AgencyMaster
        private readonly IGiAgencyMasterDA GiAgencyMasterDA;

        public AgencyMasterController(IGiAgencyMasterDA AgencyMasterDA)
        {
            GiAgencyMasterDA = AgencyMasterDA;
        }

        public async Task<ActionResult> Index()
        {
            var result = await GiAgencyMasterDA.GetAllGiAgencyMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await GiAgencyMasterDA.Find(Id);
            return View(selectProd);
        }

        public ActionResult Create()
        {
            return View();
        }
        public async Task<ActionResult> Edit(int Id)
        {
            var selectProd = await GiAgencyMasterDA.Find(Id);
            return View(selectProd);
        }
        public async Task<ActionResult> Delete(int Id)
        {
            var selectProd = await GiAgencyMasterDA.Find(Id);
            return View(selectProd);
        }
    }
}