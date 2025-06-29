using Codigo_Limpio.ejercicio2;
using Codigo_Limpio.PatronBuilder;
using Codigo_Limpio.PatronBuilder.ejecicio;

//IModelo modelo = new Plano();
//CasaCampoEconomica casa = new (modelo);

//casa.ConstruirCasa();


//Modelo ejemplo =  modelo.GetModelo();
//ejemplo.MostrarCasa();


//// rutina de ejericio 
//Entrenamiento entrenamiento = new ImplementarRutina();
//Rutina rutina = new Rutina(entrenamiento);
//rutina.Ruta();

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");

// comida en la ma;ana 
DirectorTemprano director = new DirectorTemprano();
ComidaDeMama comida = new ComidaDeMama();

director.temprano(comida);
Comida receta = comida.getComida();
receta.getComida();

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");

// comida en la tarde
DirectorTarde directorTarde = new DirectorTarde();
Tarde MedioDia = new Tarde();

directorTarde.IngredienteTarde(MedioDia);
receta = MedioDia.getComida();
receta.getComida();

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------");
