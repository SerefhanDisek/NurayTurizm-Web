using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Fatura
    {
        public int ID { get; set; }
        public decimal Tutar { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime DuzenlenmeTarihi { get; set; }
        public string BelgeNO { get; set; }
        public int TahsilatID { get; set; }
        public Tahsilat Tahsilat { get; set; }
    }
}
