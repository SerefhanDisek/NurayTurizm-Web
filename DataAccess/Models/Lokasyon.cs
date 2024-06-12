using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Lokasyon
    {
        public int ID { get; set; }
        public string TurLokasyonu { get; set; }
        public int BulunduguUlkeID { get; set; }
        public Ulke BulunduguUlke { get; set; }
    }
}
