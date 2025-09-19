using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.templateMethod.Ejericio1
{
    public abstract class Receta
    {
        public void FomarReceta() {
         Agua();
         Arroz();
         Pollo();
         CarneRes();
         CerneCerdo();
         Especias();
        }
        public virtual void Agua() { }
        public virtual void Arroz() { }
        public virtual void Pollo() { }
        public virtual void CarneRes() { }
        public virtual void CerneCerdo() { }
        public virtual void Especias() { }
    }
}
