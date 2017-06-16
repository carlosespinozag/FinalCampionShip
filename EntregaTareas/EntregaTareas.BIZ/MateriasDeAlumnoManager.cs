using EntregaTareas.COMMON.Entidades;
using EntregaTareas.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTareas.BIZ
{
    public class MateriasDeAlumnoManager : GenericManager<MateriasDeAlumnoDTO>, IMateriasDeAlumnoManager
    {
        private IGenericRepository<MateriasDeAlumnoDTO> _repo;
        public MateriasDeAlumnoManager(IGenericRepository<MateriasDeAlumnoDTO> repo): base(repo)
        {
            _repo = repo;
        }
        public async Task<List<MateriasDeAlumnoDTO>> BuscarMateriasDeAlumno(string idAlumno)
        {
            var r = await _repo.Read();
            return r.FindAll(m => m.IdAlumno == idAlumno);
        }
    }
}
