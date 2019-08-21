using CapaAccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
  public  class FacturaServices
    {
        public static FacturaServices Instancia { get; } = new FacturaServices();



        public entFactura RegistrarFactura (entFactura entFactura)
        {

            try
            {
                if (entFactura != null)
                {
                var factura =  FacturaRepository.Instancia.CrearFactura(entFactura);

                }
                else
                {
                    throw new Exception("Ocurrio un error al registrar Material");
                }
            }
            catch (Exception)
            {

                throw;
            }

            return entFactura;
        }

    }
}
