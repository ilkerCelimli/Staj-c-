using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Abstract;
namespace Repository.Abstract
{
    interface IEntityRepostory<T> where T : class, IEntity, new()
    {

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        public T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
