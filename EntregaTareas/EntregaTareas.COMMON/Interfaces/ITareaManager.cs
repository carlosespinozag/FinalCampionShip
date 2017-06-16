using EntregaTareas.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTareas.COMMON.Interfaces
{
    public interface ITareaManager:IGenericManager<TareaDTO>
    {
        Task<List<TareaDTO>> BuscarTodasLasTareasDeUnaMateria(string idMateria);
        Task<List<TareaDTO>> BuscarTareasActivasDeUnaMateria(string idMateria);
        Task<List<TareaDTO>> BuscarTareasPorEntregar(string idAlumno);
    }
}
