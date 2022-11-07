using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Orders
    {
        [Key]
        public int siparis_id { get; set; }
        public string siparis_no { get; set; }
        public int adet { get; set; }
        public DateTime siparis_tarih { get; set; }

        public Product Product { get; set; }
        public Customers Customers { get; set; }
    }

}
