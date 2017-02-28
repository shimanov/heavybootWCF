using System;
using System.IO;

namespace ClientApp.Classes
{
    /// <summary>
    /// Класс очистки Import/Export
    /// </summary>
    public class DeleteFiles : Base.IDeleteFiles
    {
        public void CleanFoldetExport()
        {
            string deleteExportPath = @"C:\GMMQ\Export";
            DeleteFolder(deleteExportPath);
        }

        public void CleanFolderImport()
        {
            string deleteExportPath = @"C:\GMMQ\Import";
            DeleteFolder(deleteExportPath);
        }

        public DateTime ExportTime()
        {
            throw new NotImplementedException();
        }

        public DateTime ImpoerTime()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="folder">Путь до каталога</param>
        static void DeleteFolder(string folder)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(folder);

                //Создаем массив дочерних вложенных каталогов folder
                DirectoryInfo[] directoryInfos = directory.GetDirectories();
                FileInfo[] file = directory.GetFiles();
                foreach (FileInfo f in file)
                {
                    f.Delete();
                }

                foreach (DirectoryInfo d in directoryInfos)
                {
                    DeleteFolder(d.FullName);

                    if (d.GetDirectories().Length == 0 && d.GetFiles().Length == 0)
                    {
                        d.Delete();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}