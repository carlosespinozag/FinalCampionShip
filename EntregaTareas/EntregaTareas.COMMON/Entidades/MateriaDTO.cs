using System;
using System.Collections.Generic;
using System.Text;

namespace EntregaTareas.COMMON.Entidades
{
    public class MateriaDTO : BaseDTO
    {
        public string IdUsuarioDocente { get; set; }
        public string Nombre { get; set; }
        public string Curso { get; set; }
        public string notas { get; set; }
    }
}
