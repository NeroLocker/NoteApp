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
    /// Класс, хранящий список всех созданных заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Хранит список созданных заметок
        /// </summary>
        private List<Note> _notesCollection = new List<Note>();

        public List<Note> NotesCollection
        {
            get { return _notesCollection; }
        }

        /// <summary>
        /// Хранит текущую заметку
        /// </summary>
        public Note CurrentNote { get; set; }

        /// <summary>
        /// Сортирует список заметок по дате изменения
        /// </summary>
        public void SortNotesCollection()
        {
            if (_notesCollection.Count == 0)
            {
                throw new InvalidOperationException("Collection has no notes");
            }
        
            this._notesCollection = BubbleSort(_notesCollection);
        }

        /// <summary>
        /// Сортирует список заметок данной категории по дате изменения, если таких заметок нет - возвращает пустой список
        /// </summary>
        public List<Note> SortNotesCollection(NoteCategory category)
        {
            if (_notesCollection.Count == 0)
            {
                throw new InvalidOperationException("Collection has no notes");
            }

            // Хранит список заметок только нужной категории
            List<Note> filteredList = new List<Note>();

            foreach (Note myCurrentNote in _notesCollection)
            {
                if (myCurrentNote.Category == category)
                {
                    filteredList.Add(myCurrentNote);
                }
            }

            if (filteredList.Count == 0)
            {
                return filteredList;
            }

            filteredList = BubbleSort(filteredList);

            return filteredList;
        }

        /// <summary>
        /// Сортирует список методом пузырька по убыванию
        /// </summary>
        /// <param name="notesCollection"></param>
        /// <returns></returns>
        private List<Note> BubbleSort(List<Note> notesCollection)
        {
            Note temp;

            // Сортируем список методом пузырька
            for (int i = 0; i < notesCollection.Count; i++)
            {
                for (int j = i + 1; j < notesCollection.Count; j++)
                {
                    if (notesCollection[i].DateOfLastEdit < notesCollection[j].DateOfLastEdit)
                    {
                        temp = notesCollection[i];
                        notesCollection[i] = notesCollection[j];
                        notesCollection[j] = temp;
                    }
                }
            }

            return notesCollection;
        }
    }
}
