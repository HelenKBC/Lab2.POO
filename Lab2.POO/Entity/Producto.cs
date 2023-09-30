using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2.POO.Entity
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public int Stock { get; set; }
        public string CodigoProducto { get; set; }
        public CategoriaProducto CategoriaProducto { get; set; }
        public Marca Marca { get; set; }
        public List<Compra> Compras { get; set; }
        public List<Venta> Ventas { get; set; }

        public void ActualizarStock(int cantidad)
        {
            
        }
    }
}
