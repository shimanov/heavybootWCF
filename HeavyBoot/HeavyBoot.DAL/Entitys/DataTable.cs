using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeavyBoot.DAL.Entitys
{
    public class DataTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        public string Pcname { get; set; }

        //Время когда я отправляю запрос на клиента
        public DateTime Dataexport { get; set; }

        //Когда клиент последний раз стучался на сервер
        public DateTime Dataimport { get; set; }

        public bool IsChecked { get; set; }
    }
}
