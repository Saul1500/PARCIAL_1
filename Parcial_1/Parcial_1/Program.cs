using Parcial_1.Entidades;
using Parcial_1.Negocio;


Usuario user = new Usuario();
ClsUsuario clsUser = new ClsUsuario();

Venta des = new Venta();
ClsVenta clsdes  = new ClsVenta();

Console.WriteLine("Ingresa tu usuario");
user.usuario = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Ingresa tu password");
user.contraseña = Console.ReadLine();

Console.WriteLine();

bool Resultado = clsUser.Autenticacion(user);
if (Resultado == true)
{
    Console.WriteLine("Bienvenido al programa");
    Console.WriteLine();

    Console.WriteLine("Ingrese el precio unitario del producto:");
    des.Precio_Del_producto = double.Parse(Console.ReadLine());

    Console.WriteLine();

    Console.WriteLine("Ingrese la cantidad de productos a comprar:");
    des.Cantidad = int.Parse(Console.ReadLine());
    Console.WriteLine();

    //String resultado = ClsVenta.Total();
    //Console.WriteLine(resultado);

}
else
{

    Console.WriteLine("Contrase Incorrecta");
}

Console.ReadLine();