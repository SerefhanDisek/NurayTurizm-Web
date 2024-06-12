using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Tur
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Açıklama { get; set; }
        public bool AktifMi { get; set; }
        public DateTime ÜyeOluşTarihi { get; set; }
        public bool YurtİçiMi { get; set; }
        public bool YurtDışıMı { get; set; }
        public ICollection<GeziProgramı> GeziProgramları { get; set; }
        public ICollection<Adres> Adresler { get; set; }
        public ICollection<TuraKayit> TuraKayitlar { get; set; }
    }
}
