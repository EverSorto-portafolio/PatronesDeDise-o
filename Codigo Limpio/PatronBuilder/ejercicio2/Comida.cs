using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.PatronBuilder.ejercicio2
{
    public class Comida
    {
        public string Pan { get; set; }
        public string Tortilla { get; set; }
        public string Lechuga { get; set; }
        public string Tomate { get; set; }
        public string Papas { get; set; }
        public string Cebolla { get; set; }
        public string Queso { get; set; }
        public string Carne { get; set; }
        public string Tocino { get; set; }
        public string pollo { get; set; }

        public void getComida()
        {
            Console.WriteLine($"" +
                $"Comida: Pan: {Pan}," +
                $" Tortilla: {Tortilla}, " +
                $"Lechuga: {Lechuga}," +
                $" Tomate: {Tomate}, " +
                $"Papas: {Papas}, " +
                $"Cebolla: {Cebolla}," +
                $" Queso: {Queso}," +
                $" Carne: {Carne}, " +
                $"Tocino: {Tocino}, " +
                $"Pollo: {pollo}");
        }
    }
}
