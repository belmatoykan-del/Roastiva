using System.Linq.Expressions;

namespace Roastiva.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class // T sınıf türünde genel bir repository arayüzü
    {
        IEnumerable<T> GetAll(); // Tüm varlıkları döndürür
        T GetFirstOrDefault(Expression<Func<T, bool>> filter); // Belirtilen filtreye göre ilk varlığı döndürür

        void Add(T entity);// Yeni bir varlık ekler
        void Remove(T entity); // Belirtilen varlığı kaldırır
        void RemoveRange(IEnumerable<T> entity); // Birden fazla varlığı kaldırır

        void Save();

    }
}



