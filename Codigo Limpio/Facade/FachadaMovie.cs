using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Facade
{
    public class FachadaMovie
    {
        private DvDPlayer _DvD;
        private sonido _sonido;
        private Proyector _proyector;
        public FachadaMovie(DvDPlayer dvD, sonido sonido, Proyector proyector)
        {
            _DvD = dvD;
            _sonido = sonido;
            _proyector = proyector;
        }

        public void ReproducirPelicula(string pelicula)
        {
            _sonido.On();
            _DvD.On();
            _proyector.On();
            _DvD.PlayMovie(pelicula);
        }
        public void DetenerPelicula()
        {
            _DvD.Off();
            _sonido.Off();
            _proyector.Off();
        }
    }
    
}
