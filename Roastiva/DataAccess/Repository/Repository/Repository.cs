using Microsoft.EntityFrameworkCore;
using Roastiva.DataAccess.Data;
using Roastiva.DataAccess.Repository.IRepository;
using System.Linq.Expressions;


namespace Roastiva.DataAccess.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly UygulamaDbContext _context;
        internal DbSet<T> dbSet;

        public Repository(UygulamaDbContext context)
        {
            _context = context;
            this.dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll() // listeleme
        {
            return dbSet.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter) // tek kayıt getirme
        {
            return dbSet.FirstOrDefault(filter);
        }

        public void Add(T entity) // ekleme
        {
            dbSet.Add(entity);
        }

        public void Remove(T entity) // silme
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity) // çoklu silme
        {
            dbSet.RemoveRange(entity);
        }

        public void Save() // kaydetme
        {
            _context.SaveChanges();
        }
    }
}
