using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeavyBoot.DAL.Entitys
{
    public class HBDataTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        public string Pcname { get; set; }

        public DateTime DateServer { get; set; }

        public DateTime DateClient { get; set; }

        public DateTime ExporTime { get; set; }

        public DateTime ImportTime { get; set; }

        public bool IsChecked { get; set; }
    }
}
