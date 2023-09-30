﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.POO.Entity
{
    public class Compra
    {
        public int NumeroFactura { get; set; }
        public string ProductoAComprar { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaCompra { get; set; }
        public Producto Producto { get; set; }
        public Factura Factura { get; set; }

        public void GenerarFactura()
        {
            
        }
    }
}
