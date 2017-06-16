using System;
using System.Collections.Generic;
using System.Text;

namespace EntregaTareas.COMMON.Entidades
{
    public class UsuariosDTO: BaseDTO
    {
        public string Nombres { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public bool EsDocente { get; set; }
        public string Matricula { get; set; }
        public string FacebookId { get; set; }
        public string Contrasenia { get; set; }
        public string Email { get; set; }
    }
}
