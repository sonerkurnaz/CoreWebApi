﻿using System.Linq.Expressions;

namespace HttpStatusCode.Infrastructure.Repository.Abstract
{
    public interface IBaseRepository<T> where T : class, new()
    {
        int Add(T input);
        int Update(T input);
        int Delete(T input);

        T Find(int id);
        ICollection<T> FindAll(Expression<Func<T, bool>> filter = null);
        IQueryable<T> FindAllInclude(Expression<Func<T, bool>> filter = null,
            params Expression<Func<T, object>>[] include);
    }
}
