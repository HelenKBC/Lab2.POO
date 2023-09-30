using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.POO.Entity
{
    public class Factura
    {
        public int NumeroFactura { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal Total { get; set; }
        public List<Compra> Compras { get; set; }
        public List<Venta> Ventas { get; set; }
        public static List<Factura> Facturas { get; set; } // Lista para almacenar las facturas.
        public void CrearFactura(int numeroFactura, DateTime fechaEmision, decimal total)
        {
            Facturas.Add(new Factura
            {
                NumeroFactura = (1+numeroFactura),
                FechaEmision = fechaEmision,
                Total = total
            });
        }
    }
}
