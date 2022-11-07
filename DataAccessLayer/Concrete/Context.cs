using EntityLayer.Concrete;
using EntityLayer.Concrete.SP;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        //Context con = new Context();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=arrds2019;database=ItTest;User Id=testuser;password=Arpas1122;integrated security=false;");
        }


        public DbSet<Product> urunler { get; set; }
        public DbSet<Customers> musteriler { get; set; }
        public DbSet<Orders> siparisler { get; set; }
        public DbSet<Job> meslekler { get; set; }
        public DbSet<Category> kategoriler { get; set; }
        public DbSet<_spSonSatilanUrunler> sonSatilanBesUrun { get; set; }

    }
}
