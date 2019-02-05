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
    public class SeferSaatleriDal
    {
        private IRepository<SeferSaat> _seferSaatRepository;
        private DbContext _dbContext;

        public SeferSaatleriDal()
        {
            _dbContext = new Context();
            _seferSaatRepository = new EFRepository<SeferSaat>(_dbContext);
        }

        public List<SeferSaat> GetAll()
        {
            return _seferSaatRepository.GetAll().ToList();
        }
    }
}
