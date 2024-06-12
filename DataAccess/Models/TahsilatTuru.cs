using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class TahsilatTuru
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public ICollection<Tahsilat> Tahsilatlar { get; set; }
    }
}
