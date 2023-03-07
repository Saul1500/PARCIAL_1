using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial_1.Entidades;

namespace Parcial_1.Negocio
{
    public class ClsUsuario
    {
        public bool Autenticacion(Usuario usuario)
        {
            if (usuario.usuario.Equals("Saul") && usuario.contraseña.Equals("1234"))
            {
                return true;
            }
            return false;


        }

    }

}

