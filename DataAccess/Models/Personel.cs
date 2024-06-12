using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Personel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Kidem { get; set; }
        public decimal Maas { get; set; }
        public string TelNo { get; set; }
        public DateTime MaasGunu { get; set; }
        public string TCNO { get; set; }
        public string Vize { get; set; }
    }
}
