using System;
using System.IO;
using ClientApp.Classes.Base;

namespace ClientApp.Classes
{
    class TimeExportImport : ITimeExportImport
    {
        public DateTime DateTimeImport()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\GMMQ\Import");
            DateTime importTime = directory.LastWriteTime;
            return importTime;
        }

        public DateTime DateTimeExport()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\GMMQ\Export");
            DateTime exporTime = directory.LastWriteTime.ToLocalTime();
            return exporTime;
        }
    }
}
