using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.POO.Entity
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string NIT { get; set; }
        public List<Producto> Productos { get; set; }

        public void AbastecerInventario(Producto producto, int cantidad)
        {
            // Actualizar el inventario del producto
            producto.ActualizarStock(cantidad);

            // Registrar la compra o abastecimiento en alguna base de datos o sistema
            Console.WriteLine("Se abasteció el inventario con " + cantidad + " unidades de " + producto.Nombre);
        }
    }
}
