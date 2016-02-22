﻿using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class DivisionMasterController : Controller
    {
        // GET: DivisionMaster
        public async Task<ActionResult> Index()
        {
            IDivisionMasterDA test = new DivisionMasterDA();
            var result = await test.GetAllDivisionMasterForViews();

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