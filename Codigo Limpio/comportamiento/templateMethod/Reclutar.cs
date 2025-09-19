using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.templateMethod
{
    public abstract class Reclutar
    {
        public  void OrdenDeContratar() {
            ReciveCV();
            Entrevista();
            EntrevistaTeorica();
            IssueOffer();
        }
        public abstract void ReciveCV();
        public abstract void Entrevista();
        public virtual void EntrevistaTeorica() {
        return;
        }
        public abstract void IssueOffer();
    }
}
