using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NEWHIRES.Interfaces
{

    public interface IGenericService<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<IEnumerable<T>> Search(Expression<Func<T, bool>> expression);

        Task<T> Find(int id);

        //Task<T> FindByAppId(int appid);

        Task<bool> Create(T entity);

        Task<bool> Update( T entity);

        Task<bool> Delete(int id);
    }


}
