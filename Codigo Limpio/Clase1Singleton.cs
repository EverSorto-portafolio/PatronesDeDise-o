using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio
{
    internal class Clase1Singleton
    {
       
        public static Clase1Singleton instancia;

        private Clase1Singleton()
        {
            // Constructor privado para evitar instanciación externa
        }
        public static Clase1Singleton getInstancia() {
            if(instancia == null)
            {
                instancia = new Clase1Singleton();
            }
            return instancia;
        }

        

    }
}
