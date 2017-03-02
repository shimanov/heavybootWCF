using System;
using ClientApp.Classes;

namespace ClientApp
{
    class Program
    {        

        static void Main()
        {
            var client = new WCFService.ServiceClient("BasicHttpBinding_IService");
            DeleteFiles delete = new DeleteFiles();
            TimeExportImport exportImport = new TimeExportImport();

            try
            {
                delete.CleanFoldetExport();
                Console.WriteLine("Каталог очищен");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            string name = "r54-630062-n";
            var r = client.DataTable(name, DateTime.Now, exportImport.DateTimeExport(), exportImport.DateTimeImport());
            Console.WriteLine("Ответ от сервера: {0}", r);

            Console.ReadKey();

        }
    }
}
