using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.ejercicio2
{
    public interface ITemprano
    {
        void Pan(string descripcion);
        void Tortilla(string descripcion);
        void Lechuga(string descripcion);
        void Tomate(string descripcion);
        void Papas(string descripcion);
        void Cebolla(string descripcion);
        void Queso(string descripcion);
        void Carne(string descripcion);
        void Tocino(string descripcion);
        void Pollo(string descripcion);
        Comida getComida();
       
    }
}
