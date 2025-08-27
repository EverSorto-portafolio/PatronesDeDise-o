using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Iterator.NewFolder
{
    public  interface IIterator<T>
    {
        bool MoveNext();
        T Next();
    }
}
