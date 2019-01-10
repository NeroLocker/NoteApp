using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс, реализующий метод сохранения и загрузки проекта в файл
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Хранит путь до файла сохранения
        /// </summary>
        private static readonly string _pathToFile = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes";

        /// <summary>
        /// Сохраняет объект проекта в файл
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        public static void SaveToFile(Project data, string filename)
        {
            File.WriteAllText(_pathToFile, JsonConvert.SerializeObject(data));
        }

        /// <summary>
        /// Загружает объект проекта из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static Project LoadFromFile(string filename)
        {
            Project project;
            string data;

            try
            {
                data = File.ReadAllText(_pathToFile);
            }

            catch (DirectoryNotFoundException e)
            {
                throw e;
            }

            catch (FileNotFoundException e)
            {
                throw e;
            }
            catch (NullReferenceException e)
            {
                throw e;
            }
            
            project = JsonConvert.DeserializeObject<Project>(data);
   
            return project;
        }
    }
}
