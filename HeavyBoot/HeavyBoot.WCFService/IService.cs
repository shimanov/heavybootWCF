using System;
using System.ServiceModel;
using HeavyBoot.DAL.Entitys;

namespace HeavyBoot.WCFService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        HBDataTable DataTable(string pcname, DateTime dataimport);
    }
}
