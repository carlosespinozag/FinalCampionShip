using System;
using System.Collections.Generic;
using System.Text;

namespace EntregaTareas.COMMON.Entidades
{
    public abstract class BaseDTO : IDisposable
    {
        /// <summary>
        /// Identificador único de la entidad (Proporcionado por Azure)
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Fecha de creación de la entidad (Proporcionado por Azure)
        /// </summary>
        //public DateTime createAt { get; set; }
        /// <summary>
        /// Fecha de ultima modificación de la entidad (Proporcionado por Azure)
        /// </summary>
        //public DateTime updateAd { get; set; }
        /// <summary>
        /// Versión de la entidad (Proporcionado por Azure)
        /// </summary>
        //public string version { get; set; }
        /// <summary>
        /// Indica que la entidad ha sido eliminada (Proporcionado por Azure)
        /// </summary>
        //public bool deleted { get; set; }


        private bool _isDisposed;
        public void Dispose()
        {
            if (!_isDisposed)
            {
                this._isDisposed = true;
                GC.SuppressFinalize(this);
            }
        }
    }
}

