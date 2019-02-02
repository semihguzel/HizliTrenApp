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
    public class SeferlerSeferSaatleriDal
    {
        private IRepository<Sefer> _seferRepository;
        private DbContext _dbContext;

        public SeferlerSeferSaatleriDal()
        {
            _dbContext = new Context();
            _seferRepository = new EFRepository<Sefer>(_dbContext);
        }
      
        public List<Sefer> GetAllSeferler()
        {
            return _seferRepository.GetAll().ToList();
        }
    }
}
