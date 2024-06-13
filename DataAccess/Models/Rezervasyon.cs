using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Rezervasyon
    {
        public int ID { get; set; }
        public int TurID { get; set; }
        public string UserID { get; set; }
        public DateTime RezervasyonTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public bool Odendi { get; set; }

        public Tur Tur { get; set; }
        public ApplicationUser User { get; set; }
    }
}
