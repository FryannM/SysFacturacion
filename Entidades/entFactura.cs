using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class entFactura
    {
        public int idFactura { get; set; }
        public  entCliente Cliente { get; set; }
        public  int clienteID { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoPago { get; set; }
        public Boolean estado { get; set; }
        public Boolean anulada { get; set; }
    }
}
