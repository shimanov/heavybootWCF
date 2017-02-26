using System;
using System.ServiceModel;
using HeavyBoot.DAL.Entitys;

namespace HeavyBoot.WCFService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        bool DataTable(string pcname, DateTime dateClient, DateTime exporTime, DateTime importTime);
    }
}
