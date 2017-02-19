using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HeavyBoot.DAL.DatabaseConnection;
using HeavyBoot.DAL.Entitys;

namespace HeavyBoot.WCFService
{
    public class Service : IService
    {
        public HBDataTable DataTable(string pcname, DateTime dataimport)
        {
            Dbconnection dbconnection = new Dbconnection();

            HBDataTable dataTable = dbconnection.HbDataTables.Find(pcname);

            if (dataTable == null)
            {
                return dbconnection.HbDataTables.Add(new HBDataTable
                {
                    Pcname = pcname,
                    Dataexport = DateTime.Now,
                    Dataimport = dataimport,
                    IsChecked = false
                });
                
            }
            else
            {
                dataTable.Dataexport = DateTime.Now;
                return dataTable;
            }
        }
    }
}
