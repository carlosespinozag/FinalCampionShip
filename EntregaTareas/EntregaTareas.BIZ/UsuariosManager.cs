using EntregaTareas.COMMON.Entidades;
using EntregaTareas.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace EntregaTareas.BIZ
{
    public class UsuariosManager : GenericManager<UsuariosDTO>, IUsuarioManager
    {
        private IGenericRepository<UsuariosDTO> _repo;
        private IMateriasDeAlumnoManager _materias;
        public UsuariosManager(IGenericRepository<UsuariosDTO> repo, IMateriasDeAlumnoManager materias) : base(repo)
        {
            _repo = repo;
            _materias = materias;
        }

        public async override Task<UsuariosDTO> BuscarPorId(string id)
        {
            var r = await _repo.Query(t => t.id == id);
            return r.SingleOrDefault();
        }

        public async Task<List<UsuariosDTO>> BuscarAlumnosEnMateria(string idMateria)
        {
            throw new NotImplementedException("No implementado");
        }

        public async Task<List<UsuariosDTO>> BuscarAlumnosPorMatricula(string matricula)
        {
            return await _repo.Query(t => t.Matricula==matricula);
        }

        public async Task<List<UsuariosDTO>> BuscarDocentes(string nombre)
        {
            return await _repo.Query(u => u.EsDocente);
        }
    }
}
