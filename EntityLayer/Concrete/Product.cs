using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int urun_id { get; set; }
        public string urun_baslik { get; set; }
        public string urun_aciklama { get; set; }
        public decimal urun_fiyat { get; set; }
        public string urun_stok { get; set; }
        public int Categorykategori_id { get; set; }
        public Category Category { get; set; }
    }
}
