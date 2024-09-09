using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CARPETA DOMINIO
//La capa de dominio es donde se definen las clases (props y metodos) que representan los objetos del mundo real que abstraemos.
//Para este proyecto, crearemos las clases Factura, DetalleFactura, Articulo, Cliente y FormaPago.


namespace ActividadPresentable01.Dominio
{
    public class Articulo
    {
        public string? Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
    }

}
