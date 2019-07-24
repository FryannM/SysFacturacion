using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entSerie
    {
        public int Id_Serie { get; set; }
        public String Numero_Serie { get; set; }

        // Relaciones
        public entSucursal sucursal { get; set; }
        public entTipComprobante tipocom { get; set; }
      
    }
}
