using Codigo_Limpio.AbstracFactory.Ejemplo2._2.InterfazPago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejemplo2._2.implementaiconstripe
{
    internal class implementarValidarUsuarioStrepi : IValidarUsuario
    {
        private Usuario _usuario;
        public implementarValidarUsuarioStrepi(Usuario usuario)
        {
            _usuario = usuario;
        }
        public bool ValidarPass(Usuario usuario)
        {

            Console.WriteLine("Validando usuario en Stripe");
            string verificar = Console.ReadLine() ?? string.Empty;
            return  verificar == usuario.passwor ? true : false;
        }

        public bool ValidarUsuario(Usuario usuario)
        {
            Console.WriteLine("Validando usuario en Stripe");
            string verificar = Console.ReadLine() ?? string.Empty;
           return verificar == usuario.user ? true : false;
        }
    }
}
