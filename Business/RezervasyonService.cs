using DataAccess;
using DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class RezervasyonService
    {
        private readonly TurContext _context;

        public RezervasyonService(TurContext context)
        {
            _context = context;
        }

        public IEnumerable<Rezervasyon> GetRezervasyonlar()
        {
            return _context.Rezervasyonlar.ToList();
        }

        public Rezervasyon GetRezervasyonById(int id)
        {
            return _context.Rezervasyonlar.Find(id);
        }

        public void CreateRezervasyon(Rezervasyon rezervasyon)
        {
            _context.Rezervasyonlar.Add(rezervasyon);
            _context.SaveChanges();
        }

        public void UpdateRezervasyon(Rezervasyon rezervasyon)
        {
            _context.Rezervasyonlar.Update(rezervasyon);
            _context.SaveChanges();
        }

        public void DeleteRezervasyon(int id)
        {
            var rezervasyon = _context.Rezervasyonlar.Find(id);
            if (rezervasyon != null)
            {
                _context.Rezervasyonlar.Remove(rezervasyon);
                _context.SaveChanges();
            }
        }
    }
}
