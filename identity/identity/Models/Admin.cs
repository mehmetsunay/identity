using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace identity.Models
{
    public class Admin
    {   //Sql'e tanımlayacağımız isimleri ekliyoruz
        [Key]
        public int AdminID { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Kullanici { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Sifre { get; set; }
    }
}
