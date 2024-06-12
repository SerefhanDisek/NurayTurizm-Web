using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class GeziProgramı
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public int KacKisilik { get; set; }
        public string Vasita { get; set; }
        public DateTime Tarih { get; set; }
        public string KalinacakYer { get; set; }
        public int KacGun { get; set; }
        public string SeyahatIpuculari { get; set; }
        public int TurID { get; set; }
        public Tur Tur { get; set; }
    }
}
