using ActividadPresentable01.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CARPETA DATOS
//La capa de datos es donde gestionamos cómo interactuar con la base de datos. 
//Usamos interfaces para definir el comportamiento esperado y luego creamos una clase que implemente 
//esa interfaz para conectarse a la base de datos usando ADO.NET.

namespace ActividadPresentable01.Datos
{
    public interface IFacturaRepository
    {
        void CrearFactura(Factura factura);
        Factura ObtenerFactura(int numeroFactura);
        void ActualizarFactura(Factura factura);
        void EliminarFactura(int numeroFactura);
    }

}
