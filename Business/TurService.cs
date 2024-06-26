using DataAccess;
using DataAccess.Models;


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

        private List<Tur> _tours = new List<Tur>
        {
            new Tur {
                ID = 1,
                Ad = "Karadeniz Yaylalar Turu",
                Açıklama = "İstanbul, Kocaeli Hareketli",
                AktifMi = true,
                ÜyeOluşTarihi = DateTime.Now,
                YurtİçiMi = true,
                YurtDışıMı = false,
                GeziProgramları = null,
                Adresler = null,
                TuraKayitlar = null,
                Rezervasyonlar = null,
                Yorumlar = null
            },
            new Tur {
                ID = 2,
                Ad = "Ege Akdeniz Turu",
                Açıklama = "Ankara Hareketli",
                AktifMi = true,
                ÜyeOluşTarihi = DateTime.Now,
                YurtİçiMi = true,
                YurtDışıMı = false,
                GeziProgramları = null,
                Adresler = null,
                TuraKayitlar = null,
                Rezervasyonlar = null,
                Yorumlar = null
            }
            // Diğer tur verileri...
        };

        public List<Tur> GetAllTours()
        {
            return _tours;
        }
    }
}


