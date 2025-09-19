using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.templateMethod.Ejericio1
{
    public class CarneAsada : Receta
    {
        private List<string> _ingrediente;
        public CarneAsada()
        {
            _ingrediente = new List<string>();
        }

        public override void Agua()
        {
            Console.WriteLine("Dos tasas de agua");
        }
        public override void Arroz()
        {
            Console.WriteLine("Una tazas de arroz");
        }
        public override void CarneRes()
        {
            Console.WriteLine("Por cada media libra de carne cocinar por 25 minutos fuego medio");
        }
        public override void Especias()
        {
            AgregandoEspecias();
        }

        private string ingresarEspecias() {
                Console.WriteLine("ingresar la espacia");
                string especia = Console.ReadLine() ?? "";
                especia = especia.Trim();
                if ( especia.All(char.IsLetter)) {
                    return especia;
                }
                return $"la especia {especia} no es valida";
        }

        public void AgregandoEspecias() {

            bool agregar = true;

            while (agregar) {
                string especia = ingresarEspecias();
                _ingrediente.Add(especia);
                agregar = FinalizarListaEspecias();
            }
        }

        public bool FinalizarListaEspecias() {
            
            Console.WriteLine("continuar s/n");
            string continuar = Console.ReadLine() ?? "n";
            continuar = continuar.ToLower();
            if (continuar.Length == 1 && continuar == "s")
            {
                return true;
            }
            return false;
        }

        public void mostrarListaEspecias() {
            foreach (string item in _ingrediente) {
                Console.WriteLine(item);
            }
        }
    }
}
