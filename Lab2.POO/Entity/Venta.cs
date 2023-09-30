using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.POO.Entity
{
    public class Venta
    {
        public int NumeroFactura { get; set; }
        public string ProductoAVender { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public Producto Producto { get; set; }
        public Factura Factura { get; set; }

        public void GenerarFactura()
        {
            
        }
    }
}
