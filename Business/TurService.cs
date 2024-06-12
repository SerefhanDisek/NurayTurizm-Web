using DataAccess;
using DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class TurService
    {
        private readonly TurContext _context;

        public TurService(TurContext context)
        {
            _context = context;
        }

        public IEnumerable<Tur> GetTurlar()
        {
            return _context.Turlar.ToList();
        }

        public Tur GetTurById(int id)
        {
            return _context.Turlar.Find(id);
        }

        // Diğer iş mantığı metodları...
    }
}

