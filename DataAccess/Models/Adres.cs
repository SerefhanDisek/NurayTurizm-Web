using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Adres
    {
        public int ID { get; set; }
        public string AdresAdı { get; set; }
        public string İl { get; set; }
        public string İlçe { get; set; }
        public string Mahalle { get; set; }
        public string Sokak { get; set; }
        public int TurID { get; set; }
        public Tur Tur { get; set; }
    }
}
