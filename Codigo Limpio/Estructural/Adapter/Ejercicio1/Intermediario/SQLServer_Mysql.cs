using Codigo_Limpio.Estructural.Adapter.Ejercicio1.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Adapter.Ejercicio1.Intermediario
{
    public class SQLServer_Mysql : IDatabase
    {
        private readonly SQLserver _sqlServer;
        public SQLServer_Mysql(SQLserver sQLserver)
        {
            _sqlServer = sQLserver ?? throw new ArgumentNullException(nameof(_sqlServer), "El objeto MySQL no puede ser nulo.");
        }
        public void Consultar(string consulta)
        {
            _sqlServer.Consultar(consulta);
        }

        public object Respuesta()
        {
            return _sqlServer.Respuesta();
        }
    }
}
