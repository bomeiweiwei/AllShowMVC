using AllShowMVC.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AllShowMVC.Service
{
    public class BaseService<T> where T : class, new()
    {
        private readonly BaseDataOperation<T> service;
        public BaseService()
        {
            this.service = new BaseDataOperation<T>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public IQueryable<T> Get(Expression<Func<T, bool>> whereLambda)
        {
            return service.GetObj.Get(whereLambda);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public T FindOne(Expression<Func<T, bool>> whereLambda)
        {
            return service.GetObj.FindOne(whereLambda);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return service.GetObj.GetAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        public int Create(T Item)
        {
            return service.GetObj.Create(Item);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        public int Update(T Item)
        {
            return service.GetObj.Update(Item);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        public int Delete(T Item)
        {
            return service.GetObj.Delete(Item);
        }

        public void Dispose()
        {
            service.GetObj.Dispose();
        }
    }
}
