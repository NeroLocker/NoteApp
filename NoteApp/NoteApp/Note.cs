using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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

        public string Name
        {
            get { return _name; }
            set
            {
                // Буквенно-цифровое выражение, подчеркивания и дефисы
                string pattern = @"^[a-zA-Z0-9_-]*$";

                if (value == null)
                {
                    throw new ArgumentException("Name value is instance of null type");
                }

                if (value.Length == 0)
                {
                    throw new ArgumentException("Name length is 0 symbols");
                }
                else if (value.Length != 0 && value.Length > 70)
                {
                    throw new ArgumentException("Name length is more than 70 symbols");
                }
                else if (value[0].ToString() == " ")
                {
                    throw new ArgumentException("Name value starts with space symbol");
                }
                else if (!Regex.IsMatch(value, pattern))
                {
                    throw new ArgumentException("Name value contains special symbols");
                }
                else
                {
                    _name = value;
                }
            }
        }

        public string Content
        {
            get { return _content; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Content value is instance of null type");
                }

                if (value.Length == 0)
                {
                    throw new ArgumentException("Content length is 0 symbols");
                }
                // Ограничения как у сообщения ВК
                else if (value.Length != 0 && value.Length > 4096)
                {
                    throw new ArgumentException("Content length is more than 4096 symbols");
                }
                else if (value[0].ToString() == " ")
                {
                    throw new ArgumentException("Content value starts with space symbol");
                }
                else
                {
                    _content = value;
                }
            }
        }

        public NoteCategory Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public DateTime DateOfCreation
        {
            get { return _dateOfCreation; }
            set { _dateOfCreation = value; }
        }

        public DateTime DateOfLastEdit
        {
            get { return _dateOfLastEdit; }
            set { _dateOfLastEdit = value; }
        }

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
                              
        /// <summary>
        /// Метод для редактирования заметки
        /// </summary>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="category"></param>
        public void Edit(string name, string content, NoteCategory category)
        {
            // TODO добавить входной параметр в виде объекта заметкии, которую хотим отредактировать
            // Считаю, что реализацию метода необходимо доработать
            Name = name;
            Content = content;
            Category = category;
            DateOfLastEdit = DateTime.Now;
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
