using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTime = System.DateTime;

namespace NoteApp
{
    /// <summary>
    /// тип данных "Категория заметки"
    /// </summary>
    public enum NoteCategory
    {
        Work,
        Home,
        HealthAndSport,
        People,
        Documents,
        Finance,
        Other
    }

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
            this.Name = name;
            this.Content = content;
            this.Category = category;
            this.SetDateOfCreation();
            this.SetDateOfLastEdit();
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
                    throw new ArgumentException("Length of name content more than 500 symbols");
                }
                else
                {
                    _content = value;
                }
            }
        }

        public DateTime DateOfCreation
        {
            get { return _dateOfCreation; }
        }

        public DateTime DateOfLastEdit
        {
            get { return _dateOfLastEdit; }
        }

        public NoteCategory Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        /// Устанавливает дату и время создания заметки для экземпляра
        /// </summary>
        private void SetDateOfCreation()
        {
            this._dateOfCreation = DateTime.Now;
        }

        /// <summary>
        /// Устанавливает дату и время последнего изменения заметки для экземпляра
        /// </summary>
        private void SetDateOfLastEdit()
        {
            this._dateOfLastEdit = DateTime.Now;
        }

        /// <summary>
        /// Метод для редактирования заметки
        /// </summary>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="category"></param>
        public void Edit(string name, string content, NoteCategory category)
        {
            this.Name = name;
            this.Content = content;
            this.Category = category;
            this.SetDateOfLastEdit();
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
