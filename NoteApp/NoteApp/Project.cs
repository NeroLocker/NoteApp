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

        /// <summary>
        /// Хранит название проекта
        /// </summary>
        private string _filename;

        public Project(string filename)
        {
            Filename = filename;            
        }

        public string Filename
        {
            get { return _filename; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Length of filename contains 0 symbols");
                }
                else if (value.Length != 0 && value.Length > 25)
                {
                    throw new ArgumentException("Length of name content more than 25 symbols");
                }
                else
                {
                    _filename = value;
                }
            }
        }

        public List<Note> NotesCollection
        {
            get { return _notesCollection; }
        }       
    }
}
