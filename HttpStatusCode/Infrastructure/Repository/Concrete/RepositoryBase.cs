using HttpStatusCode.Infrastructure.Context;
using HttpStatusCode.Infrastructure.Repository.Abstract;
using System.Linq.Expressions;

namespace HttpStatusCode.Infrastructure.Repository.Concrete
{
    public class RepositoryBase<T> : IBaseRepository<T> where T : class, new()
    {
        protected SqlDbcontext context;
        public RepositoryBase()
        {
            context = new SqlDbcontext();
        }
        public int Add(T input)
        {
            throw new NotImplementedException();
        }

        public int Delete(T input)
        {
            throw new NotImplementedException();
        }

        public T Find(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> FindAll(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAllInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public int Update(T input)
        {
            throw new NotImplementedException();
        }
    }
}
