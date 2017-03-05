using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HeavyBoot.DAL.DatabaseConnection;
using HeavyBoot.DAL.Entitys;

namespace HeavyBoot.Web.Controllers
{
    public class HomeController : Controller
    {
        Dbconnection dbconnection = new Dbconnection();

        [HttpGet]
        public ActionResult Index()
        {
            return View(dbconnection.HbDataTables);
        }
        //[HttpGet]
        //public ActionResult Index(string pcname)
        //{
        //    if (pcname == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    HBDataTable dataTable = dbconnection.HbDataTables.Find(pcname);
        //    if (dataTable != null)
        //    {
        //        return View(dbconnection.HbDataTables);
        //    }
        //    return HttpNotFound();
        //}

        [HttpPost]
        public ActionResult Index(string pcname)
        {
            var save = dbconnection.HbDataTables
                .Where(x => x.Pcname == pcname)
                .Select(x => x).ToArray();
            //dbconnection.Entry(dataTable).State = EntityState.Modified;
            dbconnection.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}