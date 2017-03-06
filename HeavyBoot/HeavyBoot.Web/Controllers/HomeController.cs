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

        [HttpPost]
        public string Index(IEnumerable<HBDataTable> dataTables)
        {
            if (dataTables.Count(x => x.IsChecked) == 0)
            {
                return "Не выбрано не одно ОПС для пинания";
            }
            foreach (HBDataTable dataTable in dataTables)
            {
                if (dataTable.IsChecked)
                {
                    dataTable.DateServer = DateTime.Now.AddMinutes(5);
                    dataTable.IsChecked = true;
                    dbconnection.SaveChanges();
                }
            }
            return "Данные сохранены";
        }
    }
}