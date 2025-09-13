using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Observer
{
    public class ObservadorTV : Isubject
    {
        private ModeloTv _modeloTv;
        private List<IObserver> _observadores;
        public ObservadorTV()
        {
             _observadores = new List<IObserver>();
        }

        public void ActualizarModelo( ModeloTv modelo) {
        _modeloTv = modelo;
            Notificar();
        }
        public void EliminarObservador(IObserver observador)
        {
           _observadores.Remove(observador); 
        }

        public void Notificar()
        {
            foreach (var observador in _observadores) {
                observador.update(_modeloTv);
            }
        }

        public void RegistrarObservador(IObserver observador)
        {
            _observadores.Add(observador);
        }
    }
}
