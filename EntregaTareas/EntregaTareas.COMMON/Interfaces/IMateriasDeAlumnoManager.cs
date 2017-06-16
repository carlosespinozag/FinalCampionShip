using EntregaTareas.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTareas.COMMON.Interfaces
{
    public interface IMateriasDeAlumnoManager:IGenericManager<MateriasDeAlumnoDTO>
    {
        Task<List<MateriasDeAlumnoDTO>> BuscarMateriasDeAlumno(string idAlumno);
    }
}
