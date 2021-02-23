using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AllShowMVC.Models;
using LinqKit;

namespace AllShowMVC.Dao
{
    public class BaseDataOperation<T> where T : class, new()
    {
        private IDataOperation<T> obj = null;
        public IDataOperation<T> GetObj
        {
            get
            {
                if (obj == null)
                {
                    obj = new DataOperation();
                }
                return obj;
            }
        }

        public class DataOperation : IDataOperation<T>
        {
            private readonly DbContext db;
            public DataOperation()
            {
                db = new AllShowEntities();
            }
            /// <summary>
            /// 取得資料
            /// </summary>
            /// <param name="whereLambda"></param>
            /// <returns></returns>
            public IQueryable<T> Get(Expression<Func<T, bool>> whereLambda)
            {
                return db.Set<T>().AsExpandable().Where(whereLambda);
            }
            /// <summary>
            /// 取得單一資料
            /// </summary>
            /// <param name="whereLambda"></param>
            /// <returns></returns>
            public T FindOne(Expression<Func<T, bool>> whereLambda)
            {
                return db.Set<T>().AsExpandable().Where(whereLambda).FirstOrDefault();
            }
            /// <summary>
            /// 取得所有資料
            /// </summary>
            /// <returns></returns>
            public IQueryable<T> GetAll()
            {
                return db.Set<T>();
            }
            /// <summary>
            /// 新增資料
            /// </summary>
            /// <param name="Item"></param>
            /// <returns></returns>
            public int Create(T Item)
            {
                try
                {
                    db.Set<T>().Add(Item);
                    return db.SaveChanges();
                }
                catch (DbEntityValidationException)
                {
                    throw;
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            /// <summary>
            /// 更新資料
            /// </summary>
            /// <param name="Item"></param>
            /// <returns></returns>
            public int Update(T Item)
            {
                try
                {
                    db.Entry(Item).State = EntityState.Modified;
                    return db.SaveChanges();
                }
                catch (DbEntityValidationException)
                {
                    throw;
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            /// <summary>
            /// 刪除資料
            /// </summary>
            /// <param name="Item"></param>
            /// <returns></returns>
            public int Delete(T Item)
            {
                try
                {
                    db.Set<T>().Remove(Item);
                    return db.SaveChanges();
                }
                catch (DbEntityValidationException)
                {
                    throw;
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            /// <summary>
            /// Dispose
            /// </summary>
            public void Dispose()
            {
                if (db != null)
                {
                    db.Dispose();
                }
            }
        }
    }
}
