using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.Classes;

namespace ClientApp
{
    class Program
    {
        static void Main()
        {
            DeleteFiles delete = new DeleteFiles();

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
            
        }
    }
}
