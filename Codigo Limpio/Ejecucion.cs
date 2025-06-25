
using Codigo_Limpio;
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