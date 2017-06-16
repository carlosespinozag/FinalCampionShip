using EntregaTareas.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTareas.COMMON.Interfaces
{
    public interface ITareaEntregadaManager:IGenericManager<TareaEntregadaDTO>
    {
        Task<List<TareaEntregadaDTO>> BuscarEntregasDeUnaTarea(string idTarea);
    }
}
