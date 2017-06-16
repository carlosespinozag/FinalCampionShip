using EntregaTareas.COMMON.Interfaces;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace EntregaTareas.DAL.Azure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        MobileServiceClient _cliente;
        IMobileServiceTable<T> _repo;
        public List<T> Resultado { get; set; }

        public GenericRepository()
        {
            _cliente = new MobileServiceClient("http://entregatareas.azurewebsites.net");
            _repo = _cliente.GetTable<T>();
        }

        public async Task<bool> Create(T entidad)
        {
            await _repo.InsertAsync(entidad);
            return true;
        }

        public async Task<bool> Delete(T entidad)
        {
            await _repo.DeleteAsync(entidad);
            return true;
        }

        public async Task<List<T>> Query(Expression<Func<T, bool>> predicado)
        {
            var consulta = _repo.IncludeTotalCount().Where(predicado);
            return await consulta.ToListAsync();
        }

        public async Task<List<T>> Read(int total = 0)
        {
            if (total == 0)
            {
                List<T> datos = new List<T>();
                int i = 0;
                int cantidad = 0;
                do
                {
                    var parte = await _repo.Skip(i * 50).ToListAsync();
                    cantidad = parte.Count;
                    datos.AddRange(parte);
                    i++;
                } while (cantidad == 50);
                return datos;
            }
            else
            {
                return await _repo.Take(total).ToListAsync();
            }
        }

        public async Task<bool> Update(T entidad)
        {
            await _repo.UpdateAsync(entidad);
            return true;
        }
    }
}

