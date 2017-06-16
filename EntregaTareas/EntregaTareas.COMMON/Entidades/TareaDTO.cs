using System;
using System.Collections.Generic;
using System.Text;

namespace EntregaTareas.COMMON.Entidades
{
    public class TareaDTO : BaseDTO
    {
        public string IdMateria { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime FechaCierre { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Notas { get; set; }
    }
}
