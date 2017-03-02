using System;
using System.ServiceModel;

namespace HeavyBoot.WCFService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string DataTable(string pcname,  DateTime dateClient, DateTime exporTime, DateTime importTime);
    }
}
