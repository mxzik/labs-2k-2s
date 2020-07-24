using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_8.entity
{
    interface Command<T>
    {
        T Do(T input);
        T UnDo(T input);
    }
}
