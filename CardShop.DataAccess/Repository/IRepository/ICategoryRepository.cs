using CardShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CardShop.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Category> GetAll();
        void Add(Category entity);
        void Update(Category entity);
        void Remove(Category entity);
        Category GetFirstOrDefault(Expression<Func<Category, bool>> filter);
        void RemoveRange(IEnumerable<Category> entity);
    }
}
