using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.ejercicio2
{
    public  class DirectorTarde
    {
         public void IngredienteTarde( Tarde comidaTarde  ) { 
        
            comidaTarde.Pan("Pan de ajo");
            comidaTarde.Tortilla("Tortilla de maíz");
            comidaTarde.Lechuga("Lechuga romana");
            comidaTarde.Tomate("sin tomate");
            comidaTarde.Papas("Papas fritas");
            comidaTarde.Pollo("Pollo asado");
        }
    }
}
