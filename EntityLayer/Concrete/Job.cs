using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    
    public class Job
    {
        [Key]
        public int meslek_id { get; set; }
        public string meslek_name { get; set; }

        public List<Customers> Customers { get; set; }
    }
}
