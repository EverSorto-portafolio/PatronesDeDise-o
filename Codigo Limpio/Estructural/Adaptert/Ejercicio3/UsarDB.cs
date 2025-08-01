using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Adaptert.Ejercicio3
{
    public class UsarDB
    {
        private readonly IDB _db;
        public UsarDB(IDB db)
        {
            _db = db;
        }
        public void Guardar()
        {
            _db.guardar();
            Console.WriteLine("insercion desde la interfaz antigua");
        }
        public void Eliminar()
        {
            _db.eliminar();
            Console.WriteLine("Delete desde la intefaz antigua");
        }
    }
}
