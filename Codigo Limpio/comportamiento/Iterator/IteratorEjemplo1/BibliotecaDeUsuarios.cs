using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Iterator.IteratorEjemplo1
{
    public class BibliotecaDeUsuarios : CreateIterator<ModeloUsuario>
    {
        private List<ModeloUsuario> _modelos;

        public BibliotecaDeUsuarios(List<ModeloUsuario> modelos)
        {
            _modelos = modelos;
        }
        

        public IteratorFacebook<ModeloUsuario> createIterator()
        { 
            return new FaebookIterator(_modelos);
        }
    }
}
