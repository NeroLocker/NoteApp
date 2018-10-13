using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс, предоставляющий возможность клонирования экземпляра
    /// </summary>
    interface ICloneable
    {
        object Clone();
    }
}
