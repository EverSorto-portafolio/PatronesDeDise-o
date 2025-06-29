using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codigo_Limpio.ejecicio
{
    public class Rutina
    {


        private Entrenamiento entrenamiento = new ImplementarRutina();
        private GupoMuscular gupoMuscular = new GupoMuscular();
        public Rutina(Entrenamiento rutina)
        {
            entrenamiento = rutina;

        }

        public void CrearRutina()
        {

            entrenamiento.pecho(true);
            entrenamiento.espalda(false);
            entrenamiento.pierna(false);
            entrenamiento.hombro(true);
            entrenamiento.bicep(true);
            entrenamiento.tricep(true);
            entrenamiento.abdominal(false);



        }

        public void MostrarRutina()
        {
            entrenamiento.mostrarGrupoMuscular();
        }

        public void Ruta()
        {
            var iterador = ((ImplementarRutina)entrenamiento).getInstance();

            foreach (var prop in iterador.GetType().GetProperties())
            {

                Console.WriteLine($" La rutina de ahora tendra {prop.Name} ?  (s/n)");
                string input = Console.ReadLine()?.Trim().ToLower();

                bool valor = input == "s" || input == "si";
                prop.SetValue(iterador, valor);
                
            }
            Console.WriteLine("Rutina actualizada correctamente.");
            entrenamiento.mostrarGrupoMuscular();
        }
        
    }
}
