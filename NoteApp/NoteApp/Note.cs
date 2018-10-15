using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTime = System.DateTime;

namespace NoteApp
{
    /// <summary>
    /// Класс, представляющий записку
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
        /// Конструктор экземпляра, который устанавливает значения полей записки
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
                    throw new ArgumentException("Length of name contains 0 symbols");
                }
                else if(value.Length != 0 && value.Length > 50)
                {
                    throw new ArgumentException("Length of name contains more than 50 symbols");
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
                if (value.Length == 0)
                {
                    throw new ArgumentException("Length of content contains 0 symbols");
                }
                else if (value.Length != 0 && value.Length > 500)
                {
                    throw new ArgumentException("Length of content contains more than 500 symbols");
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
        /// Метод для редактирования заметки
        /// </summary>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="category"></param>
        public void Edit(string name, string content, NoteCategory category)
        {
            // TODO добавить входной параметр в виде объекта записки, которую хотим отредактировать
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
