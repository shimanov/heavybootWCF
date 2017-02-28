using System;
using System.Linq;
using System.ServiceModel;
using HeavyBoot.DAL.DatabaseConnection;
using HeavyBoot.DAL.Entitys;

namespace HeavyBoot.WCFService
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service : IService
    {
        public string DataTable(string pcname, DateTime dateServer,
            DateTime dateClient, DateTime exporTime, DateTime importTime)
        {
            //Соединение с БД
            var dbconnection = new Dbconnection();

            //Ищем запись в БД
            var dataTable = dbconnection.HbDataTables.Find(pcname);

            //Если запись уже существует, тогда обновлем запись pcname
            if (dataTable != null)
                try
                {
                    var data = dbconnection.HbDataTables
                        .Where(x => x.Pcname == pcname)
                        .Select(x => x).ToArray();
                    dataTable.DateServer = DateTime.Now;
                    dataTable.DateClient = DateTime.Now;
                    dataTable.ExporTime = DateTime.Now;
                    dataTable.ImportTime = DateTime.Now;
                    dbconnection.SaveChanges();
                    return data + "_запись изменена";
                }
                catch (Exception e)
                {
                    return e.ToString();
                }

            //Если записи нет, тогда добавляем ее
            try
            {
                dbconnection.HbDataTables.Add(new HBDataTable
                {
                    Pcname = pcname,
                    DateClient = DateTime.Now,
                    DateServer = DateTime.Now,
                    ExporTime = DateTime.Now,
                    ImportTime = DateTime.Now
                });
                dbconnection.SaveChanges();
                return pcname + "_добавлено";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
