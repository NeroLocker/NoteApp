using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private List<Note> _listOfNotes = new List<Note>();

        public List<Note> ListOfNotes
        {
            get { return _listOfNotes; }
        }

        /// <summary>
        /// Метод, добавляющий новую записку
        /// </summary>
        /// <param name="note"></param>
        public void AddNote(Note note)
        {
            this._listOfNotes.Add(note);
        }

        /// <summary>
        /// Метод, удаляющий из списка записку, созданную в определённое время
        /// </summary>
        /// <param name="dateOfCreation"></param>
        public void DeleteNote(DateTime dateOfCreation)
        {
            int index = 0;

            while (index < this._listOfNotes.Count)
            {
                if (this._listOfNotes[index].DateOfCreation == dateOfCreation)
                {
                    this._listOfNotes.Remove(this._listOfNotes[index]);
                }

                index += 1;
            }
        }
    }
}
