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
        private IRepository<SeferSeferSaat> _seferSeferSaatRepository;
        private DbContext _dbContext;

        public SeferlerSeferSaatleriDal()
        {
            _dbContext = new Context();
            _seferSeferSaatRepository = new EFRepository<SeferSeferSaat>(_dbContext);
        }

        public List<SeferSeferSaat> GetBySeferID(int id)
        {
            using (Context db = new Context())
            {
                return db.SeferSeferSaatleri.Where(x => x.SeferID == id).ToList();
            }
        }
        //public List<SeferSeferSaat> DataGridSource(int id)
        //{
        //    //using (Context db = new Context())
        //    //{
        //    //    return db.SeferSeferSaatleri.Where(x => x.SeferID == id).Select(x => new
        //    //    {
                   
        //    //        x.SeferinSaati.SeferSaatBilgisi,
        //    //        x.SaatinSeferi.SeferYonu,
        //    //        x.SaatinSeferi.TahminiVarisSüresi,
        //    //        x.SaatinSeferi.YolcuKapasitesi
        //    //    }).ToList().;
        //    //}
        //}
    }
}
