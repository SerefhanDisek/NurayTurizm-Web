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

        public void CreateTur(Tur tur)
        {
            _context.Turlar.Add(tur);
            _context.SaveChanges();
        }

        public void UpdateTur(Tur tur)
        {
            _context.Turlar.Update(tur);
            _context.SaveChanges();
        }

        public void DeleteTur(int id)
        {
            var tur = _context.Turlar.Find(id);
            if (tur != null)
            {
                _context.Turlar.Remove(tur);
                _context.SaveChanges();
            }
        }
    }
}


