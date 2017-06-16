using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTareas.COMMON.Interfaces
{
    /// <summary>
    /// Define los métodos base a ser implementados por los Manager en la capa BIZ
    /// </summary>
    /// <typeparam name="T">Entidad</typeparam>
    public interface IGenericManager<T> where T : class
    {
        Task<bool> Agregar(T entidad);
        Task<bool> Eliminar(T entidad);
        Task<List<T>> ObtenerTodos(int total = 0);
        Task<bool> Actualizar(T entidad);
        Task<T> BuscarPorId(string id);
    }
}
