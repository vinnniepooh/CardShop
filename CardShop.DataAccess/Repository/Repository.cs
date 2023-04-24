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
        }
        internal DbSet<T> dbSet;
        void IRepository<T>.Add(T entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
