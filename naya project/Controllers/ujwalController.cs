using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using naya_project.Models;
namespace naya_project.Controllers
{
    public class ujwalController : Controller
    {
        daiEntities1 db = new daiEntities1();

        // GET: ujwal
        public ActionResult Index()
        {

            List<employee> all_data = db.employees.ToList();
            return View(all_data);
        }
        
    }
}