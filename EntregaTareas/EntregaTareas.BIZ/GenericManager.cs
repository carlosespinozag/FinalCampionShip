using EntregaTareas.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTareas.BIZ
{
    public class GenericManager<T> : IGenericManager<T> where T : class
    {
        private IGenericRepository<T> _repo;
        public GenericManager(IGenericRepository<T> repo)
        {
            _repo = repo;
        }
        public async Task<bool> Actualizar(T entidad)
        {
            return await _repo.Update(entidad);
        }

        public async Task<bool> Agregar(T entidad)
        {
            return await _repo.Create(entidad);
        }

        public virtual Task<T> BuscarPorId(string id)
        {
            return null;
        }

        public async Task<bool> Eliminar(T entidad)
        {
            return await _repo.Delete(entidad);
        }

        public async Task<List<T>> ObtenerTodos(int total = 0)
        {
            return await _repo.Read(total);
        }
    }
}
