using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DateTime = System.DateTime;

namespace NoteApp
{
    /// <summary>
    /// Класс, представляющий заметку
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Хранит имя
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит содержание или текст
        /// </summary>
        private string _content;

        /// <summary>
        /// Хранит категорию
        /// </summary>
        private NoteCategory _category;

        /// <summary>
        /// Хранит дату и время создания
        /// </summary>
        private DateTime _dateOfCreation;

        /// <summary>
        /// Хранит дату и время последнего изменения
        /// </summary>
        private DateTime _dateOfLastEdit;

        /// <summary>
        /// Конструктор экземпляра, который устанавливает значения полей заметки
        /// </summary>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="category"></param>
        public Note(string name, string content, NoteCategory category)
        {
            Name = name;
            Content = content;
            Category = category;
            DateOfCreation = DateTime.Now;
            DateOfLastEdit = DateTime.Now;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Name length is 0 symbols");
                }
                else if (value.Length > 70)
                {
                    throw new ArgumentException("Name length is more than 70 symbols");
                }
                else
                {
                    _name = value.Trim();
                }
            }
        }

        public string Content
        {
            get { return _content; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Content length is 0 symbols");
                }                
                else
                {
                    _content = value.Trim();
                }
            }
        }

        public NoteCategory Category
        {
            get { return _category; }
            set {_category = value;}
        }

        [JsonProperty]
        public DateTime DateOfCreation
        {
            get { return _dateOfCreation; }
            set { _dateOfCreation = value; }
        }

        [JsonProperty]
        public DateTime DateOfLastEdit
        {
            get { return _dateOfLastEdit; }
            set { _dateOfLastEdit = value; }
        }

        /// <summary>
        /// Возвращает копию экземпляра заметки
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
