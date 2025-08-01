using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Bridge.ejercicio2.ClaseAbstracta
{
    public abstract class  TipoAutomovil 
    {
        protected IAuto _auto;
        protected TipoAutomovil( IAuto auto)
        {
            _auto = auto;
        }
        public abstract void EstadoAuto();
        
        public void MostrarTipo()
        {
            Console.WriteLine("Este es un automovil de tipo: " + this.GetType().Name);
        }


    }
}
