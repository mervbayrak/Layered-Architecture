using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureExample.Core.DataAccess
{
    public interface IEntityResponsitory<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T, bool>> filter = null);
        T GetInclude<TInclude>(Expression<Func<T, TInclude>> includeEx = null, Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        List<T> GetListInclude<TInclude>(Expression<Func<T, TInclude>> includeEx = null, Expression<Func<T, bool>> filter = null);
    }
}
