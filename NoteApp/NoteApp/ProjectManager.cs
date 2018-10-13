using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс, реализующий метод сохранения и загрузки проекта в файл
    /// </summary>
    class ProjectManager
    {
        /// <summary>
        /// Хранит путь до файла сохранения
        /// </summary>
        private readonly string _pathToFile = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "My Documents\\NoteApp.notes";

        /// <summary>
        /// Сохраняет экземпляр проекта в файл
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        //public void SaveToFile(Project data, string filename)
        //{

        //}

        //public static Project LoadFromFile(string filename)
        //{

        //}
    }
}
