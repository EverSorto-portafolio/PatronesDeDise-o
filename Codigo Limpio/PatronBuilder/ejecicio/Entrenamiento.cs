using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.PatronBuilder.ejecicio
{
    public interface Entrenamiento
    {
        void pecho(bool realizar);
        void espalda(bool realizar);
        void pierna(bool realizar);
        void hombro(bool realizar);
        void bicep(bool realizar);
        void tricep(bool realizar);
        void abdominal(bool realizar);
        void mostrarGrupoMuscular();
        GupoMuscular getInstance();

    }
}
