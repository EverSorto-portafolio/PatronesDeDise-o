using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Singleton
{
    public class SingretonID
    {
        private static SingretonID instancia;
        public Guid Id { get; set; }

        private SingretonID()
        {
            Id = Guid.NewGuid();
        }
        public static SingretonID getInstancia()
        {
            if (instancia == null)
            {
                instancia = new SingretonID();
            }
            return instancia;
        }
    }
}
