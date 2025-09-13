using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Observer.ejemplo1
{

    public class ImplementacionPostulante : IPostulante
    {
        private Subasta postulante;
        private List<IObjeto> _objetoList;

        public ImplementacionPostulante()
        {
           _objetoList = new List<IObjeto>();
        }
        public void EliminarSuscripcion(IObjeto objetos)
        {
            _objetoList.Remove(objetos);
            Console.WriteLine("Eliminado de la lista de observaddores");
        }

        public void notificar()
        {
            foreach (var avisar in _objetoList) {
                avisar.update(postulante);
            }
        }

        public void Registrar(IObjeto objetos)
        {
           _objetoList.Add(objetos);
            Console.WriteLine("agregado de la lista de observaddores");

        }

        public void ActualizarPropuesta(Subasta Nuevopostulante) { 
            postulante = Nuevopostulante;
            notificar();
        }
    }
}
