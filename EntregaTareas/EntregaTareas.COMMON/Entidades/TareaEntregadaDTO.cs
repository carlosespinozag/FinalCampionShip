using System;
using System.Collections.Generic;
using System.Text;

namespace EntregaTareas.COMMON.Entidades
{
    public class TareaEntregadaDTO : BaseDTO
    {
        public string IdTarea { get; set; }
        public string IdMateria { get; set; }
        public string IdUsuarioAlumno { get; set; }
        public string Notas { get; set; }
        public string Url { get; set; }
        public DateTime FechaEntrega { get; set; }
    }
}
