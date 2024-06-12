using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Ulke
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public ICollection<Lokasyon> Lokasyonlar { get; set; }
    }
}
