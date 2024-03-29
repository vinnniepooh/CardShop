﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CardShop.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        T GetFirstOrDefault(Expression<Func<T,bool>> filter);
        void RemoveRange(IEnumerable<T> entity);
    }
}
