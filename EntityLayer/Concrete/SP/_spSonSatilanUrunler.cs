using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.SP
{
    [Keyless]
    public class _spSonSatilanUrunler
    {
        
        public string urun_baslik { get; set; }
        public decimal urun_fiyat { get; set; }
        public string kategori_ad { get; set; }
        public string siparis_no { get; set; }
        public int adet { get; set; }
        public DateTime siparis_tarih { get; set; }
        public string musteribilgi { get; set; }
        public string meslek_name { get; set; }

    }
}
