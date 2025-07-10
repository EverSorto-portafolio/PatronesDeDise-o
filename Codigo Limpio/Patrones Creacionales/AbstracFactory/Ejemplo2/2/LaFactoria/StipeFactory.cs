using Codigo_Limpio.AbstracFactory.Ejemplo2._2.implementaiconstripe;
using Codigo_Limpio.AbstracFactory.Ejemplo2._2.InterfazPago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejemplo2._2.LaFactoria
{
    internal class StipeFactory : IPasarela
    {
        private Usuario usuario;
        private  decimal _monto;
        public StipeFactory(Usuario usuario , decimal monto)
        {
            this.usuario = usuario;
            _monto = monto;
        }

        public ValidadCantidad CrearValidadCantidad()
        {
            return new implementarValidarCantidadStripe(usuario);
        }

        public IvalidadPago CrearValidarPago()
        {
            return new implementarPagoStrepi ();
        }

        public IValidarUsuario CrearValidarUsuario()
        {
           return new implementarValidarUsuarioStrepi(usuario);
        }
    }
}
