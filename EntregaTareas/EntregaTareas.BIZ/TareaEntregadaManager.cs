using EntregaTareas.COMMON.Entidades;
using EntregaTareas.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace EntregaTareas.BIZ
{
    public class TareaEntregadaManager : GenericManager<TareaEntregadaDTO>, ITareaEntregadaManager
    {
        private IGenericRepository<TareaEntregadaDTO> _repo;
        public TareaEntregadaManager(IGenericRepository<TareaEntregadaDTO> repo) : base(repo)
        {
            _repo = repo;
        }
        public async override Task<TareaEntregadaDTO> BuscarPorId(string id)
        {
            var r= await _repo.Query(t => t.id == id);
            return r.SingleOrDefault();
        }

        public async Task<List<TareaEntregadaDTO>> BuscarEntregasDeUnaTarea(string idTarea)
        {
            return await _repo.Query(t => t.IdTarea == idTarea);
        }
    }
}
