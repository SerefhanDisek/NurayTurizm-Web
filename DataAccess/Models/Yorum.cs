using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Yorum
    {
        public int ID { get; set; }
        public int TurID { get; set; }
        public string UserID { get; set; }
        public string Icerik { get; set; }
        public int Puan { get; set; }
        public DateTime YorumTarihi { get; set; }

        public Tur Tur { get; set; }
        public ApplicationUser User { get; set; }
    }
}
