using Core.Persistence.Paging;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories
{
    //generic constraint
    //class : referans tip
    //new() : new'lenebilir olmalı
    public interface IRepository<T> where T:class,new ()
    {

        T Get(Expression<Func<T, bool>> predicate);
        IPaginate<T> GetList(Expression<Func<T, bool>> predicate = null,
                             Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                             Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                             int index = 0,
                             int size = 10,
                             bool enableTracking = true,
                             CancellationToken cancellationToken = default);

        IQueryable<T> Query();
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);


        //List<T> GetAll(Expression<Func<T, bool>> filter = null);
       
    }
}
