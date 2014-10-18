using sb_admin.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sb_admin.web.Controllers
{
    public class NavbarController : Controller
    {
        // GET: Navbar
        public ActionResult Navbar(string controller, string action)
        {
            var menu = new List<Navbar>();
            menu.Add(new Navbar { Id = 1, nameOption = "Dashboard", controller = "Home", action = "Index", imageClass = "fa fa-fw fa-dashboard", estatus = true });
            menu.Add(new Navbar { Id = 2, nameOption = "Charts", controller = "Home", action = "Charts", imageClass = "fa fa-fw fa-bar-chart-o", estatus = true });
            menu.Add(new Navbar { Id = 3, nameOption = "Tables", controller = "Home", action = "Tables", imageClass = "fa fa-fw fa-table", estatus = true });
            menu.Add(new Navbar { Id = 4, nameOption = "Forms", controller = "Home", action = "Forms", imageClass = "fa fa-fw fa-edit", estatus = true });
            menu.Add(new Navbar { Id = 5, nameOption = "Bootstrap Elements", controller = "Home", action = "BootstrapElements", imageClass = "fa fa-fw fa-desktop", estatus = true });
            menu.Add(new Navbar { Id = 6, nameOption = "Bootstrap Grid", controller = "Home", action = "BootstrapGrid", imageClass = "fa fa-fw fa-wrench", estatus = true });
            menu.Add(new Navbar { Id = 7, nameOption = "Blank Page", controller = "Home", action = "BlankPage", imageClass = "fa fa-fw fa-file", estatus = true });

            menu.Where(p => p.controller == controller && p.action == action).Select(c => { c.activeli = "active"; return c; }).ToList();

            return PartialView("_navbar", menu);
        }
    }
}