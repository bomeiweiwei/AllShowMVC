using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AllShowMVC.Dao
{
    public interface IDataOperation<T> where T : class, new()
    {
        IQueryable<T> Get(Expression<Func<T, bool>> whereLambda);
        T FindOne(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> GetAll();
        int Create(T Item, bool Save);
        int Update(T Item, bool Save);
        int Delete(T Item, bool Save);
        void Dispose();
    }
}
