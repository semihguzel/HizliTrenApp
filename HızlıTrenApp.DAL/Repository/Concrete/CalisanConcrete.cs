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
    public class CalisanConcrete
    {
        //Bu kısımda, bir IRepository<Calisan> tipinde "SOYUT" yapıda yani interface ve bir DbContext tipinden değişken tanımlıyoruz. Bu değişkenleri constructer içerisinde Context'imizi ve Repository'yi kullanacak olan Calisan sınıfını, EFRepository sınıfının constructer'ına yollayarak EFRepository içerisindeki yapıları tanımladığımız IRepository tipindeki değişkenimiz ile kullanabiliyoruz. En basit anlamda Calisan class'ı için EFRepository içerisindeki yapıları kullanabilmemizi sağlıyor. Yani CalisanConcrete instance alındığı zaman,  EFRepository içerisindeki yapılar da kullanılabilecek. Örnek olması için ve sizin de kontrol etmeniz için constructer içerisine bunları yazacağım fakat yorum satırı olarak bırakacağım. Bu komut satırlarını kaldırarak yapıların kullanımına bakabilirsiniz. Sadece bu class için özel olan işlemleri bu class içerisinde tanımlayabilirsiniz. Eğer her class'ta olması gerektiğini düşündüğünüz bir metod var ise bunu IRepository ve EFRepository kısmına ekleyip deneyebilirsiniz. Kullanım yapısının anlaşılması için zaten EFRepository içerisinde tanımlanmış generic bir metod olan GetAll metodu ile Calisanların tüm listesini getiren bir metod yazacağım. Bunun gibi sizler de her class'ta farklı farklı metodları, generic olarak yazılmış metodları _calisanRepository değişkeninden kullanabilir. Hatta bu değişkenin yanına da LINQ komutları yazılabilir fakat bunların haricinde direkt olarak bu entity ile ilişkili, IRepository'de bulunmayan yapıda işlem yapılmak isteniyorsa, _dbContext ile LINQ sorgusu yazılıp istenen işlemler yapılabilir.

        private IRepository<Calisan> _calisanRepository;
        private DbContext _dbContext;

        public CalisanConcrete()
        {
            _dbContext = new Context();
            _calisanRepository = new EFRepository<Calisan>(_dbContext);
        }

        public List<Calisan> CalisanList()
        {
            return _calisanRepository.GetAll().ToList();//GetAll metodunun yanına linq sorgusu yazılabiliyor. GetAll'un normal yali db.Calisanlar'dır. EFRepository'de bu şekilde tanımlanmıştır. Eğer GetAll geriye direkt olarak tablonun listesini döndürmesini istiyorsanız ToList() komutunu yazmanız gerekir. İstenirse grup içerisinde konusarak GetAll komutunun gelen tablonun listesini döndürmesini EFRepository üzerinden sağlayabiliriz. Aşağıya da bu komutun EFRepository kullanılmadan nasıl kodlanacağını belirteceğim. Siz de ileride EFRepository'de olmayan metodlarınızı bu şekilde yazabilirsiniz.
            //return _dbContext.Set<Calisan>().ToList();//Burada Set<> içerisinde Calisan yerleştirilerek işlem yapılması gerekir. _dbContext bir DbContext tipinde ve bizim veritabanımız ile iletişime geçtiğimiz Context class'ının tipinde olmadığı için Set<Calisan>() yazarak gerekli linq komutlarını yazmamız gerekir. Eğer aklınıza takılan bir şey var ise bana sormanız yeterli. İyi çalışmalar
            //Bu frmAnasayfanin designer inda yaptigin onemli bir sey yok dimi, yok sadece listview değiştirdim çalıltırayım mı?
            //olur. yaptığım değişiklikler sadece bu iki form sana simdi bir form gostericem orda bir degisiklik yaptiysan soylersin
        }
    }
}
