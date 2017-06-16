using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTareas.COMMON.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<bool> Create(T entidad);
        Task<bool> Delete(T entidad);
        Task<List<T>> Query(Expression<Func<T, bool>> predicado);
        Task<List<T>> Read(int total = 0);
        Task<bool> Update(T entidad);
    }
}
