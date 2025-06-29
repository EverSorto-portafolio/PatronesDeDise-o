
using Codigo_Limpio.ejecicio;
using Codigo_Limpio.PatronBuilder;

IModelo modelo = new Plano();
CasaCampoEconomica casa = new (modelo);

casa.ConstruirCasa();


Modelo ejemplo =  modelo.GetModelo();
ejemplo.MostrarCasa();


// rutina de ejericio 
Entrenamiento entrenamiento = new ImplementarRutina();
Rutina rutina = new Rutina(entrenamiento);

rutina.Ruta();



