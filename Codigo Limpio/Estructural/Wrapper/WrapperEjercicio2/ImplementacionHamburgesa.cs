using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Wrapper.WrapperEjercicio2
{
    public abstract class ImplementacionHamburgesa : IBurger
    {
        protected IBurger _burger;

        public  ImplementacionHamburgesa(IBurger burger)
        {
            _burger = burger;
        }

        public virtual double Costo()
        {
          return  _burger.Costo();
        }

        public virtual string Descripcion()
        {
            return _burger.Descripcion();
        }
    }
}
