using System;

namespace ClientApp.Classes.Base
{
    interface ITimeExportImport
    {
        DateTime DateTimeImport();
        DateTime DateTimeExport();
    }
}
