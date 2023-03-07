using Parcial_1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1.Negocio
{
    public class ClsVenta
    {
   
            public double Total(Venta Producto)
            {
                
                {
                    return Producto.costo = Producto.Precio_Del_producto * Producto.Cantidad; 
                }
            }

        public void Descuento (Venta des) 
        {
            if (des.costo > 50)
                {
                    des.Precio_Del_producto = des.costo - 10;
                    Console.WriteLine ("Se ha aplicado un descuento de $10.");
                }
        }
    }
}

