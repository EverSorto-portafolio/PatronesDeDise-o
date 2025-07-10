using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Singleton
{
    public class SingletoMultiHilo
    {
        private static SingletoMultiHilo instancia;
        private static readonly object llave = new object();

        private SingletoMultiHilo()
        {
            // Constructor privado para evitar instanciación externa
        }

        public static SingletoMultiHilo GetIsntancia()
        {
            if (instancia == null)
            {
                lock (llave)
                {
                    if (instancia == null)
                    {
                        instancia = new SingletoMultiHilo();
                    }
                }
            }
            return instancia;
        }


    }
}
