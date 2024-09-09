using ActividadPresentable01.Dominio;
using ActividadPresentable01.Datos;

//CARPETA SERVICIOS
//En la capa de servicios, se define la lógica de negocio.
//Esto significa que se decide cómo interactúan las entidades entre sí y con la base de datos.

namespace ActividadPresentable01.Servicios
{
    public class FacturaServicio
    {
        private  IFacturaRepository _facturaRepository;

        public FacturaServicio(IFacturaRepository facturaRepository)
        {
            _facturaRepository = facturaRepository;
        }

        public void CrearFactura(Factura factura)
        {
            _facturaRepository.CrearFactura(factura);
        }
        public void ActualizarFactura(Factura factura)
        {
            _facturaRepository.ActualizarFactura(factura);
        }
        public void EliminarFactura(int nroFactura)
        {
            _facturaRepository.EliminarFactura(nroFactura);
        }
        public void ObtenerFactura(int nroFactura)
        {
            _facturaRepository.ObtenerFactura(nroFactura);
        }
    }

}
