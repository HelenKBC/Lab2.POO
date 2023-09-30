using Lab2.POO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.POO
{
    // Integrantes:
    // * Helen Karina Bolaños de Caceres 
    // * Luis Andres Heredia Estupinian
    // * Darío Joel Méndez Fuentes
    // * Carlos Manuel Guardado Delgado
    // * Carlos Enmanuel Flores Méndez
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso de las clases
            var cliente1 = new Cliente
            {
                Id = 1,
                Nombres = "Juan",
                Apellidos = "Perez",
                Direccion = "Calle 123",
                Telefono = "123456789",
                NIT = "123-4",
                NRC = "567-8",
                Compras = new List<Compra>(),
                Ventas = new List<Venta>()
            };

            var producto1 = new Producto
            {
                Id = 101,
                Nombre = "Zapatos",
                Descripcion = "Descripción de los Zapatos",
                Precio = 10.0m,
                Costo = 5.0m,
                Stock = 100,
                CodigoProducto = "PA001",
                CategoriaProducto = new CategoriaProducto { Id = 1, Nombre = "Calzado" },
                Marca = new Marca { Id = 1, Nombre = "Adidas" },
                Compras = new List<Compra>(),
                Ventas = new List<Venta>()
            };

            // Realizar una compra
            cliente1.RealizarCompra(producto1, 5);

            // Realizar una venta
            var venta1 = new Venta
            {
                NumeroFactura = 1,
                ProductoAVender = producto1.Nombre,
                Precio = producto1.Precio,
                Cantidad = 2,
                NombreCliente = $"{cliente1.Nombres} {cliente1.Apellidos}",
                FechaVenta = DateTime.Now,
                Producto = producto1
            };

            venta1.GenerarFactura();
            producto1.ActualizarStock(-venta1.Cantidad);

            // Realizar un pago
            var facturaVenta1 = venta1.Factura;
            cliente1.RealizarPago(facturaVenta1);
            foreach (var compra in cliente1.Compras)
            {
                compra.GenerarFactura();
                //compra.Factura.CrearFactura();
            }

           
            // Mostrar las facturas guardadas
            Console.WriteLine("Facturas guardadas en la lista:");
            foreach (var factura in Factura.Facturas)
            {
                Console.WriteLine($"Número de Factura: {factura.NumeroFactura}, Fecha de Emisión: {factura.FechaEmision}, Total: {factura.Total}");
            }
            Console.ReadKey();

        }
    }
}
