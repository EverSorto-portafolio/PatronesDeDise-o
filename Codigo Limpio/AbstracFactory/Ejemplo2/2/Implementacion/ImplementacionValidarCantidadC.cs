    using Codigo_Limpio.AbstracFactory.Ejemplo2._2.InterfazPago;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejemplo2._2
{
    public  class ImplementacionValidarCantidadC : ValidadCantidad
    {
        // primero mandamos el usuario 
        private Usuario _usuario;
        private decimal monto;

        public ImplementacionValidarCantidadC(Usuario usuario) {
            _usuario = usuario;
        }

        public decimal ValidadCantidad(Usuario usuario)
        {
            Console.WriteLine("Validando cantidad a pagar..."); // anuncia lo que se realiza
            ValidarMonto(MontoPago); // esta funcion validad los campos y la funcon que le envuelve lo verifica que sea un decimal lo que devuelve
            return CompararCantidad(); // devuelve si es mayor o menor a la cantidad que tiene el usuario en su saldo
        }

        string MontoPago() {

            try {
                Console.WriteLine("Ingrese el monto a pagar: ");
                string resultado = Console.ReadLine() ?? string.Empty;
                Console.WriteLine($"Monto ingresado: {resultado}");
                return resultado;
            } catch (Exception e) { 
                throw new Exception("Error al ingresar el monto: " + e.Message);
            }
        }

        private decimal ValidarMonto(Func<string> obtenerEntrada) {
    
            string entrada = obtenerEntrada();
            if (decimal.TryParse(entrada, out monto) && monto > 0) Console.WriteLine(monto); return monto;
      
           throw new Exception("El monto ingresado no es válido o es menor a cero."); 
        }


        private decimal CompararCantidad() {

            if (_usuario == null)
            {
                throw new InvalidOperationException("Usuario no inicializado");
            }
            if (_usuario.Saldo >= monto) {
                Console.WriteLine($"Saldo del usuario: {_usuario.Saldo}, Monto a pagar: {monto}");
                Console.WriteLine("El monto ingresado es válido y se puede pagar.");

                return monto; // si el saldo del usuario es mayor o igual al monto que se quiere pagar, devuelve el monto
            }
             throw new Exception("El monto ingresado es mayor a la cantidad disponible.");
        }

        
    }
}
