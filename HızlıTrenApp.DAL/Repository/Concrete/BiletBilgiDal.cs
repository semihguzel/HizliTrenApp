using HızlıTrenApp.DAL.Repository.Abstract;
using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL.Repository.Concrete
{
    public class BiletBilgiDal
    {
        private IRepository<BiletBilgi> _biletBilgiRepository;
        private DbContext _dbContext;

        public BiletBilgiDal()
        {
            _dbContext = new Context();
            _biletBilgiRepository = new EFRepository<BiletBilgi>(_dbContext);
        }
        public List<BiletBilgi> GetByDate(DateTime dateTime)
        {
            using (Context db = new Context())
            {
                return db.BiletBilgileri.Where(x => x.BiletTarihi == dateTime).ToList();
            }
        }

        public List<BiletBilgi> TicketList()
        {
            return _dbContext.Set<BiletBilgi>().ToList();
        }
    }
}
