using DataAccess;
using DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class YorumService
    {
        private readonly TurContext _context;

        public YorumService(TurContext context)
        {
            _context = context;
        }

        public IEnumerable<Yorum> GetYorumlar()
        {
            return _context.Yorumlar.ToList();
        }

        public Yorum GetYorumById(int id)
        {
            return _context.Yorumlar.Find(id);
        }

        public void CreateYorum(Yorum yorum)
        {
            _context.Yorumlar.Add(yorum);
            _context.SaveChanges();
        }

        public void UpdateYorum(Yorum yorum)
        {
            _context.Yorumlar.Update(yorum);
            _context.SaveChanges();
        }

        public void DeleteYorum(int id)
        {
            var yorum = _context.Yorumlar.Find(id);
            if (yorum != null)
            {
                _context.Yorumlar.Remove(yorum);
                _context.SaveChanges();
            }
        }
    }
}
