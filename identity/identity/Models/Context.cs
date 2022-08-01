






using Microsoft.EntityFrameworkCore;

namespace identity.Models

{
    public class Context : DbContext
    {
        //DbSetten Kalıtım alıyoruz burada nuget yüklü değilse yükleyelim
        //override işlemi yapıp sql bağlatımızı kuruyoruz.
        //tools pakatını kuruyoruz. Kurduktan sonra package manager kısmında migration oluştuyoruz
        //sql bağlatımızı yapıyoruz. Önemli nokta kurduğumuz database sql de bulunmasın sıfırdan kuralım isim tanımlamasını ona göre yapınız
        //sql de veri girişi yapınız.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-UDMLI44\\SQLEXPRESS;Database=HospitalDb;Trusted_Connection=true;");
        }
        public DbSet<Admin> Admins { get; set; }


    }
}
