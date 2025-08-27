using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Iterator.IteratorEjemplo1
{
    public  class FaebookIterator : IteratorFacebook<ModeloUsuario>
    {
        private List<ModeloUsuario> _modeloUsuario;
        private int _posicion = 0;

        private List<ModeloUsuario> _modelo;
        public FaebookIterator(List<ModeloUsuario> modelo)
        {
            _modelo = modelo;
        }

        public ModeloUsuario CurrentUser()
        {
            throw new NotImplementedException();
        }

        public bool HasNextUSer()
        {
            return _posicion < _modelo.Count();
        }

        public ModeloUsuario NextUser()
        {
             var usuario = _modelo[_posicion];
            _posicion++;
            return usuario;
        }

       

    }
}
