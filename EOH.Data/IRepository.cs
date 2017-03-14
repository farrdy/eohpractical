﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EOH.Data
{
    public interface IRepository<T> where T : class
    {
      
        T Add(T entity);     
        T Update(T entity);      
        void Delete(T entity);
   
        void Delete(Expression<Func<T, bool>> where);     
        T GetById(int id);   
        T Get(Expression<Func<T, bool>> where);
       
       IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
    }
}
