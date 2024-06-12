using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class TuraKayit
    {
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public decimal NetFiyat { get; set; }
        public decimal BrutFiyat { get; set; }
        public decimal Indirim { get; set; }
        public string KayitNo { get; set; }
        public int TurID { get; set; }
        public Tur Tur { get; set; }
    }
}
