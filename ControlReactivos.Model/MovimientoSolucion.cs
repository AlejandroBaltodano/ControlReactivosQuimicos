using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlReactivos.Model
{
   public class MovimientoSolucion
    {
        public int NumeroMovimiento { set; get; }
        public string NombreProfesor { set; get; }
        public string NombreUsuario { set; get; }
        public string NombreSolucion { set; get; }
        public string NombreMovimiento { set; get; }
        public DateTime FechaTransaccion { set; get; }
        public float CantidadMovimiento { set; get; }
        public string UnidadAlmacenamiento { set; get; }

    }
}
