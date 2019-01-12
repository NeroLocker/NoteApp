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
        /// Текущая выбранная заметка
        /// </summary>
        public Note CurrentNote { get; set; }

        /// <summary>
        /// Сортирует список заметок по дате изменения
        /// </summary>
        public void SortNotesCollection()
        {
            Note temp;

            if (_notesCollection.Count == 0)
            {
                throw new NullReferenceException("Collection has no notes");
            }
            
            for (int i = 0; i < _notesCollection.Count; i++)
            {
                for (int j = i + 1; j < _notesCollection.Count; j++)
                {
                    if (_notesCollection[i].DateOfLastEdit < _notesCollection[j].DateOfLastEdit)
                    {
                        temp = _notesCollection[i];
                        _notesCollection[i] = _notesCollection[j];
                        _notesCollection[j] = temp;
                    }
                }
            }            
        }

        /// <summary>
        /// Сортирует список заметок данной категории по дате изменения 
        /// </summary>
        public List<Note> SortNotesCollection(NoteCategory category)
        {
            if (_notesCollection.Count == 0)
            {
                throw new NullReferenceException("Collection has no notes");
            }

            // Хранит список заметок только нужной категории
            List<Note> filteredList = new List<Note>();

            foreach (Note currentNote in _notesCollection)
            {
                if (currentNote.Category == category)
                {
                    filteredList.Add(currentNote);
                }
            }

            Note temp;
           
            for (int i = 0; i < filteredList.Count; i++)
            {
                for (int j = i + 1; j < filteredList.Count; j++)
                {
                    if (filteredList[i].DateOfLastEdit < filteredList[j].DateOfLastEdit)
                    {
                        temp = filteredList[i];
                        filteredList[i] = filteredList[j];
                        filteredList[j] = temp;
                    }
                }
            }

            return filteredList;
        }
    }
}
