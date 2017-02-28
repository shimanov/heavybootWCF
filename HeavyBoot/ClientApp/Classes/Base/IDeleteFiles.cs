using System;

namespace ClientApp.Classes.Base
{
    public interface IDeleteFiles
    {
        void CleanFoldetExport();

        void CleanFolderImport();

        DateTime ExportTime();

        DateTime ImpoerTime();
    }
}