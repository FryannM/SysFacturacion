using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
   public class entCliente
    {
        public int Id_Cliente { get; set; }
        public String NumeroDoc_Cliente { get; set; }
        public String Nombre_Cliente { get; set; }
        public String FechaNac_Cliente { get; set; }
        public String Sexo_Cliente { get; set; }
        public String Telefono_Cliente { get; set; }
        public String Celular_Cliente { get; set; }
        public String Correo_Cliente { get; set; }
        public String Direccion_Cliente { get; set; }
        public Boolean Estado_Cliente { get; set; }
        public int UsuarioCreacion_Cliente { get; set; }
        public int UsuarioUpdate_Cliente { get; set; }

        // Relaciones
        public entTipoDocumento tipodocumento { get; set; }

    }
}
