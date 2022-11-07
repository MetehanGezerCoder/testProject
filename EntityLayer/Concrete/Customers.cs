using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customers
    {
        [Key]
        public int musteri_id { get; set; }
        public string musteri_mail { get; set; }
        public string musteri_sifre { get; set; }
        public string musteri_ad { get; set; }
        public string musteri_soyad { get; set; }
        public DateTime kayit_tarih { get; set; }
        public int Jobmeslek_id { get; set; }
        public Job Job { get; set; }

        public List<Orders> Orders { get; set; }


    }
}
