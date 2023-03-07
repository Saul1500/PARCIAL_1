using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1.Entidades
{
    public  class Venta
    {
       public int  ID { get; set; }

       public string? Nombre_del_Producto { get; set; }

       public string? Descripcion_del_Producto { get; set; }

       public double Precio_Del_producto { get; set; }

       public int  Cantidad { get; set; }

       public double costo { get; set; }
    }
}
