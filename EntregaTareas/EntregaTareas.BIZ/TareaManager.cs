using EntregaTareas.COMMON.Entidades;
using EntregaTareas.COMMON.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTareas.BIZ
{
    public class TareaManager : GenericManager<TareaDTO>, ITareaManager
    {
        IGenericRepository<TareaDTO> _repo;
        public TareaManager(IGenericRepository<TareaDTO> repo) : base(repo)
        {
            _repo = repo;
        }

        public async Task<List<TareaDTO>> BuscarTareasActivasDeUnaMateria(string idMateria)
        {
            return await _repo.Query(t => t.IdMateria == idMateria && t.FechaCierre < DateTime.Now.Date);
        }

        public async Task<List<TareaDTO>> BuscarTareasPorEntregar(string idAlumno)
        {
            //TODO: implementar
            throw new NotImplementedException("Falta por implementar esta función");
        }

        public async Task<List<TareaDTO>> BuscarTodasLasTareasDeUnaMateria(string idMateria)
        {
            return await _repo.Query(t => t.IdMateria == idMateria);
        }

        public override async Task<TareaDTO> BuscarPorId(string id)
        {
            var r= await _repo.Query(t => t.id == id);
            return r.SingleOrDefault();
        }
    }
}
