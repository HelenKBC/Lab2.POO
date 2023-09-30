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
       
    }
}
