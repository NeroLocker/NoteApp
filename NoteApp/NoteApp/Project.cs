using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NoteApp
{
    /// <summary>
    /// Класс, хранящий словарь всех созданных записок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Хранит список созданных записок
        /// </summary>
        private List<Note> _notesCollection = new List<Note>();

        public List<Note> NotesCollection
        {
            get { return _notesCollection; }
        }       
    }
}
