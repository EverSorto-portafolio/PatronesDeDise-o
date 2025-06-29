using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.ejecicio
{
    public class ImplementarRutina : Entrenamiento
    {
        private GupoMuscular grupoMuscular = new();

        public void abdominal(bool realizar)
        {
            grupoMuscular.Abdominal = realizar;
        }

        public void bicep(bool realizar)
        {
            grupoMuscular.Bicep = realizar;
        }

        public void espalda(bool realizar)
        {
            grupoMuscular.Espalda = realizar;
        }

        public GupoMuscular getInstance()
        {
            return grupoMuscular;
        }

        public void hombro(bool realizar)
        {
            grupoMuscular.Hombro = realizar;
        }

        public void mostrarGrupoMuscular()
        {
            grupoMuscular.MostrarGrupoMuscular();
        }

        public void pecho(bool realizar)
        {
            grupoMuscular.Pecho = realizar;
        }

        public void pierna(bool realizar)
        {
            grupoMuscular.Pierna = realizar;
        }

        public void tricep(bool realizar)
        {
            grupoMuscular.Tricep = realizar;
        }


    }
}
