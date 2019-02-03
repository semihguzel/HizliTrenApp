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
    public class BiletConcrete
    {
        private IRepository<Bilet> _biletRepository;
        private DbContext _dbContext;

        public BiletConcrete()
        {
            _dbContext = new Context();
            _biletRepository = new EFRepository<Bilet>(_dbContext);
        }
        public List<Bilet> BiletListesi()
        {
            return _biletRepository.GetAll().ToList();
        }
    }
}
