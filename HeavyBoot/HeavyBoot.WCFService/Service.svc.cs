using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HeavyBoot.DAL.DatabaseConnection;
using HeavyBoot.DAL.Entitys;

namespace HeavyBoot.WCFService
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service : IService
    {
        public bool DataTable(string pcname, DateTime dateClient, DateTime exporTime, DateTime importTime)
        {
            Dbconnection dbconnection = new Dbconnection();

            HBDataTable dataTable = dbconnection.HbDataTables.Find(pcname);

            if (dataTable == null)
            {
                dbconnection.HbDataTables.Add(new HBDataTable
                {
                    Pcname = pcname,
                    DateClient = dateClient,
                    IsChecked = false
                });
                return false;
            }
            else
            {
                HBDataTable[] dataTables = dbconnection.HbDataTables
                .Where(x => x.Pcname == pcname)
                .Select(x => x).ToArray();

                dataTable.DateServer = DateTime.Now;
                dataTable.DateClient = dateClient;
                dataTable.ExporTime = exporTime;
                dataTable.ImportTime = importTime;

                return dataTables[0].IsChecked;

                

            }
            

        }
    }
}
