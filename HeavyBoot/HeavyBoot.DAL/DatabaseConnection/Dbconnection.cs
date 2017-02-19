using System.Data.Entity;
using HeavyBoot.DAL.Entitys;

namespace HeavyBoot.DAL.DatabaseConnection
{
    public class Dbconnection : DbContext
    {
        public Dbconnection() : base("")
        {
            
        }

        public DbSet<DataTable> DataTables { get; set; }
    }
}
