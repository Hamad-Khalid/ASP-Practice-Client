using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class ProgramController : Controller
    {
        //
        // GET: /Program/
        public ActionResult ProgName()
        {
            List<Models.Program> programs = new List<Models.Program>();
            programs.Add(new Models.Program() { Name = "Sports", time = "10:30" });
            programs.Add(new Models.Program() { Name = "Film", time = "11:30" });
            programs.Add(new Models.Program() { Name = "News", time = "12:30" });
            return View(programs);
        }

        public ActionResult Programmy()
        {
            List<Models.Program> programs = new List<Models.Program>();
            programs.Add(new Models.Program() { Name = "Sports", time = "10:30" });
            programs.Add(new Models.Program() { Name = "Film", time = "11:30" });
            programs.Add(new Models.Program() { Name = "News", time = "12:30" });
            return View(programs);
        }
    }
}