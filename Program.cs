using ActividadPresentable01.Datos;
using ActividadPresentable01.Dominio;
using ActividadPresentable01.Servicios;

IFacturaRepository facturaRepository = new FacturaRepository();
FacturaServicio facturaServicio = new FacturaServicio(facturaRepository);

try
{
    Factura nuevaFactura = new Factura
    {
        NumeroFactura = 3,
        Fecha = DateTime.Now,
        FormaPago = new FormaPago { Nombre = "Tarjeta" },
        Cliente = new Cliente { Nombre = "Juan", Apellido = "Pérez", DNI = 14345638 }
    };
    facturaServicio.CrearFactura(nuevaFactura);
    Console.WriteLine("Factura creada con éxito.");
}
catch
{
    Console.WriteLine("F");
}


