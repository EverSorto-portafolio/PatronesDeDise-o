using Codigo_Limpio.AbstracFactory.Ejemplo2._2.InterfazPago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejemplo2._2
{
    internal class ImplementrarValidarUsuario : IValidarUsuario
    {
        private Usuario _usuario;
        private string user, pass; 

        public ImplementrarValidarUsuario(Usuario usuario)
        {
            _usuario = usuario;
        }
        public bool ValidarPass(Usuario usuario)
        {
                
            InsertarUsuario();
            InsertarPass();
           return CapturarError(compararUsuario);

        }

        public bool ValidarUsuario(Usuario usuario)
        {
            if (user == usuario.user) { 
                Console.WriteLine(usuario.user);
                return true; 
            } // solo es para consultar el usuario 
            return false;

        }

        void InsertarPass() {
            Console.WriteLine("Ingrese su contraseña: ");
            pass = Console.ReadLine() ?? string.Empty;
        }

        void InsertarUsuario()
        {
            Console.WriteLine("Ingrese su usuario: ");
            user = Console.ReadLine() ?? string.Empty;
        }

        bool compararUsuario() {
            
                if (user != _usuario.user && pass != _usuario.passwor) return false;
                return true;
        }

        bool CapturarError( Func<bool> funcion) {

            try { 
                Console.WriteLine("Validando usuario y contraseña...");
                bool resultado = funcion();
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar el usuario/password  " + ex.Message);
            }
        }


    }
}
