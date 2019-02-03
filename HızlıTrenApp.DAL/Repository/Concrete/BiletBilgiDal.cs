using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL.Repository.Concrete
{
    public class BiletBilgiDal
    {
        public List<BiletBilgi> GetByDate(DateTime dateTime)
        {
            using (Context db=new Context())
            {
                return db.BiletBilgileri.Where(x => x.BiletTarihi == dateTime).ToList();
            }
        }
    }
}
