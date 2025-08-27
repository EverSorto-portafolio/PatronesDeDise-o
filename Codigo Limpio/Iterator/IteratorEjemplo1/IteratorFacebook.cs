using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Iterator.IteratorEjemplo1
{
    public  interface IteratorFacebook<T>
    {
       T CurrentUser();
    // funciona como controlador para definir si existe otro elemento
       bool  HasNextUSer(); 
       T  NextUser();
    }
}
