using Codigo_Limpio.AbstracFactory.Ejemplo2._2.InterfazPago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejemplo2._2.LaFactoria
{
    public class Paypal : IPasarela
    {
        private Usuario _usuario;
        private decimal _monto { get; set; }
        public Paypal(Usuario usuario)
        {
            _usuario = usuario;
        }
        public ValidadCantidad CrearValidadCantidad()
        {
            return new ImplementacionValidarCantidadC(_usuario);
        }

        public IvalidadPago CrearValidarPago()
        {
            return new ImplementacionRealizarPago(_usuario, _monto);
        }

        public IValidarUsuario CrearValidarUsuario()
        {
            return new ImplementrarValidarUsuario(_usuario);
        }

       
    }
}
