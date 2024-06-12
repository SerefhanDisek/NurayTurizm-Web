using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Tahsilat
    {
        public int ID { get; set; }
        public decimal Tutar { get; set; }
        public DateTime Tarih { get; set; }
        public int TahsilatTuruID { get; set; }
        public TahsilatTuru TahsilatTuru { get; set; }
        public ICollection<Fatura> Faturalar { get; set; }
    }
}
