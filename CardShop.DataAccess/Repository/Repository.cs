using CardShop.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CardShop.DataAccess.Repository
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        public Repository(ApplicationDbContext db)
        {

            _db = db;
            this.dbSet = _db.Set<T>();
        }
        internal DbSet<T> dbSet;
        void IRepository<T>.Add(T entity)
        {
            dbSet.Add(entity);

        }

        void IRepository<T>.Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public IEnumerable<T>GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        void IRepository<T>.Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
