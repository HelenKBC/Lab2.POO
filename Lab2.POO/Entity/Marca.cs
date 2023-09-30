using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.POO.Entity
{
    public class Marca
    {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public List<Producto> Productos { get; set; }
       

    }
}
