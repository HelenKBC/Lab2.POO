using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.POO.Entity
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string NIT { get; set; }
        public string NRC { get; set; }

        public void RealizarCompra(Producto producto, int cantidad)
        {
            // Verificar si el producto está disponible en el inventario
            if (producto.Stock >= cantidad)
            {
                // Crear una nueva instancia de Compra
                Compra compra = new Compra
                {
                    Producto = producto,
                    Precio = producto.Precio,
                    Cantidad = cantidad,
                    NombreCliente = this.Nombres + " " + this.Apellidos,
                    FechaCompra = DateTime.Now
                };

                // Generar la factura y realizar el pago
                compra.GenerarFactura();
                this.RealizarPago(compra.Factura);

                // Actualizar el inventario
                producto.ActualizarStock(-cantidad);
            }
            else
            {
                Console.WriteLine("El producto no está disponible en la cantidad requerida.");
            }
        }

        public void RealizarPago(Factura factura)
        {
            Console.WriteLine("Se realizó el pago de la factura #" + factura.NumeroFactura);
        }
    }
}
