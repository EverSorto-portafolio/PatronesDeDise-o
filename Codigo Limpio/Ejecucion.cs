
using Codigo_Limpio;
using Codigo_Limpio.prueba;
#region SingletonSinId
Console.WriteLine("Hola mundo");
Clase1Singleton instancia = Clase1Singleton.getInstancia();
Console.WriteLine(instancia.GetType());
#endregion

#region SingletonConId
SingretonID instanciaID = SingretonID.getInstancia();
SingretonID instanciaID2 = SingretonID.getInstancia();
SingretonID instanciaID3 = SingretonID.getInstancia();

Console.WriteLine(instanciaID.Id);
Console.WriteLine(instanciaID2.Id);
Console.WriteLine(instanciaID3.Id);
#endregion

#region EjemploSingletonLog

EventLogger logger = EventLogger.GetInstance();
logger.LogEvent("Inicio de la aplicación");
logger.LogEvent("Se ha realizado una operación importante");

EventLogger logger2 = EventLogger.GetInstance();
logger2.LogEvent("Se ha realizado otra operación importante en la base de datos esperando");
logger2.LogEvent("Se ha realizado otra operación importante Asyncrona");
logger2.LogEvent("Consulta exitosa pasamos al siguiente dato");

logger.LogEvent("Se ha realizado una operación de cierre de sesión");
logger.LogEvent("Fin de la aplicación");
logger.MostrarLogs();


#endregion