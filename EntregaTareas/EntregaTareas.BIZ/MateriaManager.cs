using EntregaTareas.COMMON.Entidades;
using EntregaTareas.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTareas.BIZ
{
    public class MateriaManager:GenericManager<MateriaDTO>, IMateriaManager
    {
        private IGenericRepository<MateriaDTO> _repo;
        private IMateriasDeAlumnoManager _materias;
        public MateriaManager(IGenericRepository<MateriaDTO> repo, IMateriasDeAlumnoManager materias):base(repo)
        {
            _repo = repo;
            _materias = materias;
        }

        public async Task<List<MateriaDTO>> BuscarMateriasDeAlumno(string IdAlumno)
        {
            var mats= await _materias.BuscarMateriasDeAlumno(IdAlumno);
            List<MateriaDTO> materias = new List<MateriaDTO>();
            foreach (var item in mats)
            {
                materias.Add(await BuscarPorId(item.IdMateria));
            }
            return materias;
        }

        public async Task<List<MateriaDTO>> BuscarMateriasDeDocente(string IdDocente)
        {
            var r = await ObtenerTodos();
            return r.FindAll(m => m.IdUsuarioDocente == IdDocente);
        }

        public async override Task<MateriaDTO> BuscarPorId(string id)
        {
            var r = await _repo.Query(m => m.id == id);
            return r.SingleOrDefault();
        }
    }
}
