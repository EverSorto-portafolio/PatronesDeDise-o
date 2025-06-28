
using Codigo_Limpio.PatronBuilder;

IModelo modelo = new Plano();
CasaCampoEconomica casa = new (modelo);

casa.ConstruirCasa();


Modelo ejemplo =  modelo.GetModelo();
ejemplo.MostrarCasa();



