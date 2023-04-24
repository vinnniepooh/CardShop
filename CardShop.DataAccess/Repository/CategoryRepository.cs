using CardShop.DataAccess.Repository.IRepository;
using CardShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CardShop.DataAccess.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<Category> dbSet;
        public CategoryRepository(ApplicationDbContext db, DbSet<Category> category)
        {
            _db = db;
            this.dbSet = _db.Set<Category>();                                       
        }
        public void Add(Category entity)
        {
           dbSet.Add(entity);
        }

        public IEnumerable<Category> GetAll()
        {
            IQueryable<Category> query = dbSet;
            return query.ToList();
        }

        public Category GetFirstOrDefault(Expression<Func<Category, bool>> filter)
        {
            IQueryable<Category> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public void Remove(Category entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Category> entity)
        {
            dbSet.RemoveRange(entity);
        }

        public void Update(Category entity)
        {
            dbSet.Update(entity);
        }
    }
}
