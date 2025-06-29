using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.ejercicio2
{
    public class ComidaDeMama : ITemprano
    {
       private  Comida comida = new Comida();

        public void Carne(string descripcion)
        {
            comida.Carne = descripcion;
        }

        public void Cebolla(string descripcion)
        {
            comida.Cebolla = descripcion;
        }

        public Comida getComida()
        {
            return comida;
        }

        public void Lechuga(string descripcion)
        {
            comida.Lechuga = descripcion;
        }

        public void Pan(string descripcion)
        {
            comida.Pan = descripcion;
        }

        public void Papas(string descripcion)
        {
            comida.Papas = descripcion;
        }

        public void Pollo(string descripcion)
        {
            comida.pollo = descripcion;
        }

        public void Queso(string descripcion)
        {
            comida.Queso = descripcion;
        }

        public void Tocino(string descripcion)
        {
            comida.Tocino = descripcion;
        }

        public void Tomate(string descripcion)
        {
            comida.Tomate = descripcion;
        }

        public void Tortilla(string descripcion)
        {
            comida.Tortilla = descripcion;
        }
    }
}
