using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.SP
{
    [Keyless]
    public class _spEnCokSatilanUcUrun
    {
        string urun_baslik { get; set; }
        string Cok { get; set; }
    }
}
