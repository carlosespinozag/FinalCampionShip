using EntregaTareas.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTareas.COMMON.Interfaces
{
    public interface IUsuarioManager:IGenericManager<UsuariosDTO>
    {
        Task<List<UsuariosDTO>> BuscarDocentes(string nombre);
        Task<List<UsuariosDTO>> BuscarAlumnosEnMateria(string idMateria);
        Task<List<UsuariosDTO>> BuscarAlumnosPorMatricula(string matricula);

    }
}
