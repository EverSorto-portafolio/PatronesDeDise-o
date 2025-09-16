using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.State.Ejemplo1
{
    public class Contexto
    {
        public ImaquinaExpendedora _maquina;

        public Contexto()
        {
            _maquina = new Esperando();
        }

        public void CambiarEstado(ImaquinaExpendedora estado) {
        _maquina = estado;
        }

        public void SelecionarProducto(string producto) {
            _maquina.SelecionarProducto(producto);
        }
        public void PagarProducto(int pago) { 
            _maquina.PagarProducto(pago);
        }
        public void DispenseProducto() {
           _maquina.DispenseProducto();
        }
    }
}
